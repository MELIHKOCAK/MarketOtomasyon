using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace melihkocak0385
{
    public partial class frm_kategori : Form
    {
        db d = new db();
        frm f = new frm();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I6L92IT\SQLEXPRESS03;Initial Catalog=IlkOtomasyon;Integrated Security=True");      //database bağlantısı

        public frm_kategori()
        {
            InitializeComponent();
        }

        //
        //Formun Loadı
        //

        private void frm_kategori_Load(object sender, EventArgs e)
        {
            this.tBL_KATEGORITableAdapter.Fill(this.ilkOtomasyonDataSet.TBL_KATEGORI);                                         //Datagridviewi form yüklenirken doldurmak için
            ToolTip aciklama = new ToolTip();                                                                                 //Tooltip için nesne türettim
            aciklama.SetToolTip(btn_sifirla, "Aşağıda Yazılı Olan Bilgileri Siler(Herhangi Bir Veri Kaybı Yaşanmaz)");       //Textboxların üstündeki küçük buton için tooltip
            error_no.BlinkStyle = ErrorBlinkStyle.NeverBlink;                                                               //ErrorProviderın blink style ayarı
            cmbx_ara.SelectedIndex = 0;                                                                                    //Arama comboxın form yüklenin seçili gelmesi için.
        }


        //
        //Kategori Ekleme Butonu
        //

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int b;
            if (txt_no.Text == null || txt_no.Text == "")//Kayıt Eklerken Primary Alanının Boş Girilemeyeceği için textboxın boş girilmesini engelledim.
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez.");  //ErrorProvdier İle uyarıyoruz.
            }
            else
            { b = Convert.ToInt32(txt_no.Text);
                if (b>=255)//veri tabanında Kategori No tinyint veri tipinde tutuluyor 255 den fazla girince hat veriyor engellemek için yaptım.
                {
                    MessageBox.Show("Kategori No Alanı İçin 255 den Yukarı Bir Değere Girilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İşlem Başarılı Mesajı
                }
                else
                {
                    d.prkeykontrol("prkeykontrolkategori", txt_no);//Primary key alanına aynı veri iki kere girilmediği için db classındaki prkeykontrol metodu ile alanı kontrol ediyorum
                    int a = Convert.ToInt32(d.y);//db classındaki primary key kontorlü için değişken oluşturmuştum onu int veri tipine çeviriyorum.
                    if (a == 1)//kayıt etkilendiyse yani kayıt varsa hata mesajı verecek.
                    {
                        MessageBox.Show("Lütfen No Alanını Daha Önce Kullanılmamış Bir Değer Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                    }
                    else
                    {
                        d.eklegunsil("insert into TBL_KATEGORI values(@p1,@p2)", txt_no, txt_ad); //Eğer ilgili textbox boş değilse db classındaki eklegünsil metodu textboxlara yazılan değerleri içine gönderdiğim sql kodu ile işleyecek.
                        if (d.x != 0)  //Db classındaki x değişkeni row affectedi tutuyor 0 dan farklı ise işlemleri gerçekleştiriyor
                        {
                            d.listele("select * from TBL_KATEGORI", dataGridView1);  //db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
                            MessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//İşlem Başarılı Mesajı
                        }
                    }
                    
                }
                
            }
        }

        //
        //Kategori Listeleme Butonu
        //

        private void btn_listele_Click(object sender, EventArgs e)
        {
            d.listele("select * from TBL_KATEGORI", dataGridView1);   //db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
        }

        //
        //Kategori Silme Butonu
        //

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "") //Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Kategori Numarasına Göre Silinme İşlemi Yapılacaktır 'Kategori No' Alanını Boş Bırakmayınız!", "Hata İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez.");        //Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.eklegunsil("delete from TBL_KATEGORI where K_No=@p1", txt_no); //db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod satırı
                if (d.x == 0)   //Olmayan bir kaydı silmeyi engelliyoruz.
                {
                    MessageBox.Show("Olmayan Bir Kayıdı Silmeye Çalıştınız. Gerekli Alanları Kontrol Ediniz.", "Hata İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);   //İlgili Mesajı Gösteriyoruz.
                    error_no.SetError(txt_no, "Bu Alan Boş Geçilemez"); //Errorprovdier ile uyarıyoruz.
                }
                else
                {
                    d.listele("select * from TBL_KATEGORI", dataGridView1); //Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
                    f.sifirla(txt_no, txt_ad);                              //sildikten sonra textboxları sıfırlıyoruz.
                    MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); //İlgili Mesajı Gösteriyoruz.
                }
            }
        }

        //
        //Textboxları Sıfırlama Butonu
        //

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            f.sifirla(txt_no, txt_ad);    //frm classındaki 'sifirla' metodu parametre olarak verdiğimiz textboxları sıfırlar
        }

        //
        // Kategori Güncelleme Butonu
        //

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "")   //Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Kategori Numarasına Göre Güncelleme İşlemi Yapılacaktır 'Kategori No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);   //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez"); //Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.eklegunsil("update TBL_KATEGORI set K_Ad=@p2 where K_No=@p1 ", txt_no, txt_ad);   //db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod
                if (d.x == 0)       //Olmayan bir kaydı güncellemeyi engelliyoruz.
                    MessageBox.Show("Olmayan Bir Kayıdı Güncellemeye Çalıştınız. Lütfen Dikkat Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);   //İlgili Mesajı Gösteriyoruz.
                else
                {
                    d.listele("select * from TBL_KATEGORI", dataGridView1);//Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değer gösterecek
                    MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);    //İlgili Mesajı Gösteriyoruz.
                }

            }
        }

        //
        //Kategori Arama Butonu
        //

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (cmbx_ara.SelectedIndex == 1)//Comboboxda Birinci seçenek seçili ise No ya göre ara yapılacak
            {
                d.ara("select * from TBL_KATEGORI where K_No = @p1", txt_no, dataGridView1);//db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak No'ya göre arama işlemini gerçekleştiriyor.
            }
            else if (cmbx_ara.SelectedIndex == 2)//Comboboxda ikinci seçenek seçili ise Ada ya göre ara yapılacak
            {
                d.ara("select * from TBL_KATEGORI where RTRIM(K_Ad) LIKE '%" + txt_ad.Text + "%'", txt_ad, dataGridView1);  //db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak Ada göre arama işlemini gerçekleştiriyor.
            }
        }

        //----------------- ToolStrip Öğelerinin Click Eventi-------------------------------------
        private void tumunusecToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlardaki verinin tümünü seçmek için ContextMenuStrip aracının 'tumunusec' öğesinin click eventi
        {
            f.tumunusec(this);      //frm classındaki tumunusec metodu ile textboxlardaki verinin tümünü seçiyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }    

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlardaki veriyi kopyalamak için ContextMenuStrip aracının 'kopyala' öğesinin click eventi
        {
            f.kopyala(this);         //frm classındaki kopyala metodu ile textboxlardaki veriyi kopyalama işlemi yapıyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }     

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlara veriyi yapıştırmak için ContextMenuStrip aracının 'yapistir' öğesinin click eventi
        {
            f.yapistir(this);       //frm classındaki yapistir metodu ile textboxlara panodaki veriyi yapıştırıyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        } 

        private void kesToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlardaki veriyi kesmek için ContextMenuStrip aracının 'kes' öğesinin click eventi
        {
            f.kes(this);            //frm classındaki kes metodu ile textboxlardaki veriyi kesme işlemi yapıyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }       

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)   //Formdan sağ tık yaparak çıkmak için ContextMenuStrip aracının 'cikis' öğesinin click eventi
        {
            this.Close();       //İlgili formu kapatıyoruz.
        } 
        //-------------------------------------------------------------------------------------------------

        //------------Error Provdier Silinmesi İçin Gerekli Event-----------
        private void txt_no_TextChanged(object sender, EventArgs e)
        {
            if (txt_no.Text!="")        // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_no.Clear();
        }
        //------------------------------------------------------------------

        //--TextBoxlara Yanlış Veri Girişini Engellemek İçin Gerekli Eventler--
        private void txt_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }   //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.
        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.
        //---------------------------------------------------------------------

        //
        //Ürün Ara Comboboxı SelectedIndexChanged
        //

        private void cmbx_ara_SelectedIndexChanged(object sender, EventArgs e)  //Kulanıcın kafası karışmasını engellemek amaçlı yapılmıştır. 
        {
            if (cmbx_ara.SelectedIndex == 0)        //Comboboxın SelectedIndex 0 Yani 'Seçiniz' ise aşağıdaki işlemler gerçekleştirilecek
            {
                txt_no.Visible = true;
                txt_ad.Visible = true;
                btn_ekle.Enabled = true;
                btn_guncelle.Enabled = true;
                btn_listele.Enabled = true;
                btn_sil.Enabled = true;
                btn_ara.Enabled = false;
            }

            else if (cmbx_ara.SelectedIndex == 1)   //Comboboxın SelectedIndex 1 Yani 'No'ya Göre Ara' ise aşağıdaki işlemler gerçekleştirilecek
            { 
                txt_no.Visible = true;
                txt_ad.Visible = false;
                btn_ara.Enabled = true;
                btn_ekle.Enabled = false;
                btn_guncelle.Enabled = false;
                btn_listele.Enabled = false;
                btn_sil.Enabled = false;
            }

            else if (cmbx_ara.SelectedIndex == 2)   //Comboboxın SelectedIndex 2 Yani 'Ad'a Göre Ara' ise aşağıdaki işlemler gerçekleştirilecek
            {
                txt_no.Visible = false;
                txt_ad.Visible = true;
                btn_ara.Enabled = true;
                btn_ekle.Enabled = false;
                btn_guncelle.Enabled = false;
                btn_listele.Enabled = false;
                btn_sil.Enabled = false;
            }
        }

        //
        //DataGridView CellClick(Satırlara Tıklayınca Verileri İlgili Textboxlara Taşımak İçin)
        //

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d.tasima(txt_no, txt_ad, dataGridView1, e);    //db classındaki 'tasima' metodu datagridviewin hücrelerine tıklayınca değerleri ilgili textboxlara taşıma işlemini yapar.
        }

        //
        //İşlemler Ve İstastistikler Arası Geçiş Segmenti
        //

        private void sgmt_kategori_IndexChanged(object sender, EventArgs e)     //Burada bir trick kullanılmıştır ilk başta aktif olan işlemler panelidir eğer segment değiştirilirse işlemler paneli gizlenir istatistik paneli gösterilir.
        {
            if (sgmt_kategori.SelectedIndex == 0)       //XanderUI sınıfından segment aracının seçili değeri 0 ise işlemler panelini(ekleme, silme, güncelleme....) Gösteriyoruz.
            {
                pnl_istatistik.Hide();
                pnl_islem.Show();
                chart1.Series.Remove(chart1.Series["Kategori Sayısı"]);     //Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoruz.
            }
            else if (sgmt_kategori.SelectedIndex == 1)//XanderUI sınıfından segment aracının seçili değeri 1 ise istatistikler panelini gösteriyoruz.
            {
                d.istatistiky("select count(*) from TBL_KATEGORI", chart1, "Kategori Sayısı");      //İstatistikler segmentine geçince db classındaki istatistiky metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
                pnl_islem.Hide();
                pnl_istatistik.Show();
                pnl_istatistik.Location = pnl_islem.Location;
            }
        }
    }
}
