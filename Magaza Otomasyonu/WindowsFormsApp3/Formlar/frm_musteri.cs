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
using System.Net.Configuration;

namespace melihkocak0385
{
    public partial class frm_musteri : Form
    {
        db d = new db();                                
        frm f = new frm();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I6L92IT\SQLEXPRESS03;Initial Catalog=IlkOtomasyon;Integrated Security=True");      //database bağlantısı

        public frm_musteri()
        {
            InitializeComponent();
        }

        //
        //Formun Loadı
        //

        private void frm_musteri_Load(object sender, EventArgs e)
        {
            this.tBL_MUSTERİTableAdapter.Fill(this.ilkOtomasyonDataSet.TBL_MUSTERİ);    //Datagridviewi form yüklenirken doldurmak için
            cmbx_ara.SelectedIndex = 0;     //arama kutusunun ilk aşamada seçili gelmesi için
            ToolTip aciklama = new ToolTip();   //Tooltip için nesne türettim
            aciklama.SetToolTip(btn_sıfırla, "Aşağıda Yazılı Olan Bilgileri Siler(Herhangi Bir Veri Kaybı Yaşanmaz)");      //Textboxların üstündeki küçük buton için tooltip
            error_no.BlinkStyle = ErrorBlinkStyle.NeverBlink;   //ErrorProviderın blink style ayarı
            error_ad.BlinkStyle = ErrorBlinkStyle.NeverBlink;   //ErrorProviderın blink style ayarı
            error_soyad.BlinkStyle = ErrorBlinkStyle.NeverBlink;    //ErrorProviderın blink style ayarı
        }
     
        //
        //Müşteri Listeleme Butonu
        //

        private void btn_listele_Click(object sender, EventArgs e)
        {
            d.listele("Select * from TBL_MUSTERİ", dataGridView1);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
        }

        //
        //Müşteri Ekleme Butonu
        //

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "")   //Kayıt Eklerken Primary Alanının Boş Girilemeyeceği için textboxın boş girilmesini engelledim.
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez.");    //ErrorProvdier İle uyarıyoruz.
                error_ad.SetError(txt_soyad, "Bu Alan Boş Geçilemez."); //ErrorProvdier İle uyarıyoruz.
                error_soyad.SetError(txt_ad, "Bu Alan Boş Geçilemez."); //ErrorProvdier İle uyarıyoruz.
            }
            else
            {
                d.prkeykontrol("prkeykontrolmusteri", txt_no);//Primary key alanına aynı veri iki kere girilmediği için db classındaki prkeykontrol metodu ile alanı kontrol ediyorum
                int a = Convert.ToInt32(d.y);//db classındaki primary key kontorlü için değişken oluşturmuştum onu int veri tipine çeviriyorum.
                if (a == 1)//kayıt etkilendiyse yani kayıt varsa hata mesajı verecek.
                {
                    MessageBox.Show("Lütfen No Alanını Daha Önce Kullanılmamış Bir Değer Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                }
                else
                {
                    d.eklegunsil("insert into TBL_MUSTERİ values(@p1,@p2,@p3,@p4,@p5)", txt_no, txt_ad, txt_soyad, txt_tel, txt_mail); //Eğer ilgili textbox boş değilse db classındaki eklegünsil metodu textboxlara yazılan değerleri içine gönderdiğim sql kodu ile işleyecek.
                    if (d.x != 0)
                    {
                        d.listele("Select * from TBL_MUSTERİ", dataGridView1);  //Db classındaki x değişkeni row affectedi tutuyor 0 dan farklı ise işlemleri gerçekleştiriyor
                        MessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);    //İlgili Mesajı Gösteriyoruz.
                    }
                }
               
            }
        }

        //
        //Müşteri Güncelle Butonu
        //

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "")   //Kayıt Güncellerken Primary Alanının Boş Girilemeyeceği için textboxın boş girilmesini engelledim.
            {
                MessageBox.Show("Müşteri Numarasına Göre Güncelleme İşlemi Yapılacaktır 'Müşteri No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);   //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu alan boş geçilemez"); //ErrorProvdier İle uyarıyoruz.
            }
            else
            {
                d.eklegunsil("update TBL_MUSTERİ set M_Ad=@p1,M_Soyad=@p2,M_Tel=@p3,M_Mail=@p4 where M_No=@p5", txt_ad, txt_soyad, txt_tel, txt_mail, txt_no);  //db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod
                if (d.x == 0) //Olmayan bir kaydı güncellemeyi engelliyoruz.
                    MessageBox.Show("Olmayan Bir Kayıdı Güncellemeye Çalıştınız. Lütfen Dikkat Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                else
                {
                    d.listele("Select * from TBL_MUSTERİ", dataGridView1);  //Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değer gösterecek
                    MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);    //İlgili Mesajı Gösteriyoruz.
                }
            }

        }

        //
        //Müşteri Silme Butonu
        //

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "")   //Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Müşteri Numarasına Göre Silinme İşlemi Yapılacaktır 'Müşteri No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez.");    //Errorprovdier ile uyarıyoruz.
            }

            else
            {
                d.eklegunsil("delete from TBL_MUSTERİ where M_No=@p1", txt_no); //db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod
                if (d.x == 0)   //Olmayan bir kaydı silmeyi engelliyoruz.
                {
                    MessageBox.Show("Olmayan Bir Kayıdı Silmeye Çalıştınız. Gerekli Alanları Kontrol Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                    error_no.SetError(txt_no, "Bu Alan Boş Geçilemez."); //Errorprovdier ile uyarıyoruz.
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); //İlgili Mesajı Gösteriyoruz.
                    d.listele("Select * from TBL_MUSTERİ", dataGridView1); //Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değer gösterecektir.
                    f.sifirla(txt_no, txt_ad, txt_soyad, txt_mail, txt_tel);//sildikten sonra textboxları sıfırlıyoruz.
                }
            }
            
        }
        
        //
        //Müşteri Ara ComboBox SelectedIndexChanged
        //

        private void cmbx_ara_SelectedIndexChanged(object sender, EventArgs e)  //Kulanıcın kafası karışmasını engellemek amaçlı yapılmıştır.
        {
            if (cmbx_ara.SelectedIndex == 0)    //Comboboxın SelectedIndex 0 Yani 'Seçiniz' ise aşağıdaki işlemler gerçekleştirilecek
            {
                txt_soyad.Visible = true;
                txt_tel.Visible = true;
                txt_mail.Visible = true;
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
                txt_soyad.Visible = false;
                txt_tel.Visible = false;
                txt_mail.Visible = false;
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
                txt_soyad.Visible = false;
                txt_tel.Visible = false;
                txt_mail.Visible = false;
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
        //Müşteri Arama Butonu
        //

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (cmbx_ara.SelectedIndex==1)  // Birinci seçenek seçili ise No ya göre ara yapılacak
                d.ara("select * from TBL_MUSTERİ where M_No = @p1", txt_no, dataGridView1);     //db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak No'ya göre arama işlemini gerçekleştiriyor.

            else if (cmbx_ara.SelectedIndex == 2)
                d.ara("select * from TBL_MUSTERİ where RTRIM(M_Ad) LIKE '%"+txt_ad.Text+"%'", txt_no, dataGridView1);   //db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak Ada göre arama işlemini gerçekleştiriyor.
        }

        //
        //TextBoxları Sıfırlama Butonu
        //

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {

            f.sifirla(txt_no, txt_ad, txt_soyad, txt_mail,txt_tel);     //db classındaki 'sifirla' metodu parametre olarak verdiğimiz textboxları sıfırlar
        }

        //
        //İşlemler Ve İstatistikler Arası Geçiş Segmenti
        //

        private void sgmt_musteri_IndexChanged(object sender, EventArgs e)  //Burada bir trick kullanılmıştır ilk başta aktif olan işlemler panelidir eğer segment değiştirilirse işlemler paneli gizlenir istatistik paneli gösterilir.
        {
            if (sgmt_musteri.SelectedIndex == 0)    //XanderUI sınıfından segment aracının seçili değeri 0 ise işlemler panelini(ekleme, silme, güncelleme....) Gösteriyoruz.
            {
                pnl_istatistik.Hide();
                pnl_islem.Show();
                chart1.Series.Remove(chart1.Series["Müşteri Sayısı"]);  //Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoruz.
            }
            else if (sgmt_musteri.SelectedIndex == 1)   ////XanderUI sınıfından segment aracının seçili değeri 1 ise istatistikler panelini Gösteriyoruz.
            {
                d.istatistiky("Select count(M_No) from TBL_MUSTERİ", chart1, "Müşteri Sayısı"); //İstatistikler segmentine geçince db classındaki istatistiky metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
                pnl_islem.Hide();
                pnl_istatistik.Show();
                pnl_istatistik.Location = pnl_islem.Location;
            }
        }

        //
        //DataGridView CellClick
        //

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d.tasima(txt_no, txt_ad, txt_soyad, txt_tel, txt_mail, dataGridView1, e); //db classındaki 'tasima' metodu datagridviewin hücrelerine tıklayınca değerleri ilgili textboxlara taşıma işlemini yapar
        }

        //--------------ToolStrip Öğelerinin Click Eventi------------------------------------
        private void tumunusectoolStripMenuItem1_Click(object sender, EventArgs e) //Textboxlardaki verinin tümünü seçmek için ContextMenuStrip aracının 'tumunusec' öğesinin click eventi
        {
            f.tumunusec(this);   //frm classındaki tumunusec metodu ile textboxlardaki verinin tümünü seçiyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlardaki veriyi kopyalamak için ContextMenuStrip aracının 'kopyala' öğesinin click eventi
        {
            f.kopyala(this);  //frm classındaki kopyala metodu ile textboxlardaki veriyi kopyalama işlemi yapıyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlara veriyi yapıştırmak için ContextMenuStrip aracının 'yapistir' öğesinin click eventi
        {
            f.yapistir(this);   //frm classındaki yapistir metodu ile textboxlara panodaki veriyi yapıştırıyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e) //Textboxlardaki veriyi kesmek için ContextMenuStrip aracının 'kes' öğesinin click eventi
        {
            f.kes(this);    //frm classındaki kes metodu ile textboxlardaki veriyi kesme işlemi yapıyoruz. İçine bu anlamındaki 'this' sözcüğünü yani ilgili formu yolluyoruz.
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) //Formdan sağ tık yaparak çıkmak için ContextMenuStrip aracının 'cikis' öğesinin click eventi
        {
            this.Close();   //İlgili formu kapatıyoruz.
        }
        //--------------------------------------------------------------------------------------

        //-----Error Provdilerin Silinmesi İçin Gerekli Eventler--------
        private void txt_no_TextChanged(object sender, EventArgs e)
        {
            if (txt_no.Text != "")  // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_no.Clear();
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            if (txt_ad.Text != "")  // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_ad.Clear();
        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {
            if (txt_soyad.Text != "")   // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_soyad.Clear();
        }
        //--------------------------------------------------------------------------------------

        //--TextBoxlara Yanlış Veri Girişini Engellemek İçin Gerekli Eventler--
        private void txt_no_KeyPress(object sender, KeyPressEventArgs e) //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e) //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece metinsel ifadelere izin veriyor. 
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e) //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece metinsel ifadelere izin veriyor.
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        //---------------------------------------------------------------------
    }
}
