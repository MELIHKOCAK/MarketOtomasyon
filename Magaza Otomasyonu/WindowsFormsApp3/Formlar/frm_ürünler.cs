using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melihkocak0385
{
    public partial class frm_urun : Form
    {
        db d = new db();
        frm f = new frm();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I6L92IT\SQLEXPRESS03;Initial Catalog=IlkOtomasyon;Integrated Security=True");

        public frm_urun()
        {
            InitializeComponent();
        }

        //
        //Formun Loadı
        //

        private void frm_ürünler_Load(object sender, EventArgs e)
        {
            this.tBL_URUNTableAdapter.Fill(this.ilkOtomasyonDataSet.TBL_URUN);//Datagridviewi form yüklenirken doldurmak için
            this.tBL_TEDARIKCILERTableAdapter.Fill(this.ilkOtomasyonDataSet.TBL_TEDARIKCILER);//Datagridviewi form yüklenirken doldurmak için
            this.tBL_KATEGORITableAdapter.Fill(this.ilkOtomasyonDataSet.TBL_KATEGORI);//Datagridviewi form yüklenirken doldurmak için
            this.tBL_URUNTableAdapter.Fill(this.ilkOtomasyonDataSet.TBL_URUN);//Datagridviewi form yüklenirken doldurmak için
            cmbx_ara.SelectedIndex = 0;     //arama kutusunun ilk aşamada seçili gelmesi için
            ToolTip aciklama = new ToolTip();//Tooltip için nesne türettim
            aciklama.SetToolTip(btn_sıfırla, "Aşağıda Yazılı Olan Bilgileri Siler(Herhangi Bir Veri Kaybı Yaşanmaz)");//Textboxların üstündeki küçük buton için tooltip
        }

        //
        //Ürün Listeleme Butonu
        //

        private void btn_listele_Click(object sender, EventArgs e)
        {
            d.listele("select * from TBL_URUN",dataGridView1); //db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
        }

        //
        //Ürün Ekleme Butonu
        //

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "")//Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez");//Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.prkeykontrol("prkeykontrolurun", txt_no);     //Primary key alanına aynı veri iki kere girilmediği için db classındaki prkeykontrol metodu ile alanı kontrol ediyorum
                int a = Convert.ToInt32(d.y);                   //db classındaki primary key kontorlü için değişken oluşturmuştum onu int veri tipine çeviriyorum.
                if (a == 1)                                     //kayıt etkilendiyse yani kayıt varsa hata mesajı verecek.
                {
                    MessageBox.Show("Lütfen No Alanını Daha Önce Kullanılmamış Bir Değer Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                }
                else
                {
                    d.eklegunsil("insert into TBL_URUN values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", txt_no, txt_ad, txt_alis, txt_satis, cmbx_kategori, cmbx_tedarik, txt_stok);//Eğer ilgili textbox boş değilse db classındaki eklegünsil metodu textboxlara yazılan değerleri içine gönderdiğim sql kodu ile işleyecek.
                    if (d.x != 0)//Db classındaki x değişkeni row affectedi tutuyor 0 dan farklı ise işlemleri gerçekleştiriyor
                    {
                        d.listele("select * from TBL_URUN", dataGridView1);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
                        MessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//İlgili Mesajı Gösteriyoruz.
                    }
                }
            }
        }

        //
        //Ürün Silme Butonu
        //

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text == "")//Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Ürün Numarasına Göre Silinme İşlemi Yapılacaktır 'Ürün No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez.");//Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.eklegunsil("delete from TBL_URUN where U_No=@p1", txt_no);//db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod satırı
                if (d.x == 0)
                {
                    MessageBox.Show("Olmayan Bir Kayıdı Silmeye Çalıştınız Gerekli Alanları Kontrol Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                    error_no.SetError(txt_no, "Bu Alan Boş Geçilemez");//Errorprovdier ile uyarıyoruz.
                }
                else
                {
                    f.sifirla(txt_no, txt_ad, txt_satis, txt_alis,txt_stok);//sildikten sonra textboxları sıfırlıyoruz.
                    d.listele("select * from TBL_URUN", dataGridView1);//Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
                    MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//İlgili Mesajı Gösteriyoruz.
                }
            }
        }

        //
        //Textboxları Sıfırlama Butonu
        //

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            f.sifirla(txt_ad, txt_alis, txt_no, txt_satis,txt_stok);//db classındaki 'sifirla' metodu parametre olarak verdiğimiz textboxları sıfırlar
        }

        //
        //Ürün Güncelleme Butonu
        //

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_no.Text == null || txt_no.Text== "")//Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Ürün Numarasına Göre Güncelleme İşlemi Yapılacaktır 'Ürün No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                error_no.SetError(txt_no, "Bu Alan Boş Geçilemez");//Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.eklegunsil("update TBL_URUN set U_Ad=@p2,U_Alis=@p3,U_Satis=@p4,K_No=@p5,T_No=@p6, U_Stok = @p7 where U_No=@p1 ", txt_no, txt_ad, txt_alis, txt_satis, cmbx_kategori, cmbx_tedarik,txt_stok );//db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod
                if (d.x == 0)//Olmayan bir kaydı güncellemeyi engelliyoruz.
                    MessageBox.Show("Olmayan Bir Kayıdı Güncellemeye Çalıştınız. Lütfen Dikkat Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error); //İlgili Mesajı Gösteriyoruz.
                else
                {
                    d.listele("SELECT * FROM TBL_URUN", dataGridView1);//Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değer gösterecek
                    MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); //İlgili Mesajı Gösteriyoruz.
                }
                d.listele("select * from TBL_URUN", dataGridView1);//Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değer gösterecek
            }
        }

        //
        //Ürün Arama Butonu
        //

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (cmbx_ara.SelectedIndex == 1)//Comboboxda Birinci seçenek seçili ise No ya göre ara yapılacak
            {
                d.ara("select * from TBL_URUN where U_No = @p1", txt_no, dataGridView1);//db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak No'ya göre arama işlemini gerçekleştiriyor.
            }
            else if (cmbx_ara.SelectedIndex == 2)//Comboboxda ikinci seçenek seçili ise Ada ya göre ara yapılacak
            {
                d.ara("select * from TBL_URUN where RTRIM(U_Ad) LIKE '%" + txt_ad.Text + "%'", txt_ad, dataGridView1);//db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak Ada göre arama işlemini gerçekleştiriyor.
            }
        }


        //----------------- İlgili ToolStrip Öğelerinin Click Eventi-------------------------------------

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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)   //Formdan sağ tık yaparak çıkmak için ContextMenuStrip aracının 'cikis' öğesinin click eventi
        {
            this.Close();       //İlgili formu kapatıyoruz.
        }
        private void tumunusectoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f.tumunusec(this);
        }

        //----------------------------------------------------------------------------------------

        //-----Error Provdilerin Silinmesi İçin Gerekli Eventler--------
        private void txt_no_TextChanged(object sender, EventArgs e)
        {
            if (txt_no.Text != "")        // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_no.Clear();
        }
        //---------------------------------------------------------------

        //--TextBoxlara Yanlış Veri Girişini Engellemek İçin Gerekli Eventler--
        private void txt_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }   //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_alis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_satis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.
        //-----------------------------------------------------------------------

        //
        //Ürün Ara Comboboxı SelectedIndexChanged
        //

        private void cmbx_ara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_ara.SelectedIndex == 0)//Comboboxın SelectedIndex 0 Yani 'Seçiniz' ise aşağıdaki işlemler gerçekleştirilecek
            {
                cmbx_tedarik.Visible = true;
                cmbx_kategori.Visible = true;
                txt_alis.Visible = true;
                txt_satis.Visible = true;
                txt_no.Visible = true;
                txt_ad.Visible = true;
                btn_ekle.Enabled = true;
                btn_guncelle.Enabled = true;
                btn_listele.Enabled = true;
                btn_sil.Enabled = true;
                txt_stok.Visible = true;
                btn_ara.Enabled = false;
            }

            else if (cmbx_ara.SelectedIndex == 1)//Comboboxın SelectedIndex 1 Yani 'No'ya Göre Ara' ise aşağıdaki işlemler gerçekleştirilecek
            {
                cmbx_tedarik.Visible = false;
                cmbx_kategori.Visible = false;
                txt_alis.Visible = false;
                txt_satis.Visible = false;
                txt_no.Visible = true;
                txt_ad.Visible = false;
                btn_ara.Enabled = true;
                btn_ekle.Enabled = false;
                btn_guncelle.Enabled = false;
                btn_listele.Enabled = false;
                btn_sil.Enabled = false;
                txt_stok.Visible = false;
            }
            else if (cmbx_ara.SelectedIndex == 2) //Comboboxın SelectedIndex 2 Yani 'Ad'a Göre Ara' ise aşağıdaki işlemler gerçekleştirilecek
            {
                cmbx_tedarik.Visible = false;
                cmbx_kategori.Visible = false;
                txt_alis.Visible = false;
                txt_satis.Visible = false;
                txt_no.Visible = false;
                txt_ad.Visible = true;
                btn_ara.Enabled = true;
                btn_ekle.Enabled = false;
                btn_guncelle.Enabled = false;
                btn_listele.Enabled = false;
                btn_sil.Enabled = false;
                txt_stok.Visible = false;
            }
        }

        //
        //İşlemler Ve İstastistikler Arası Geçiş Segmenti
        //

        private void sgmt_urun_IndexChanged(object sender, EventArgs e)//Burada bir trick kullanılmıştır ilk başta aktif olan işlemler panelidir eğer segment değiştirilirse işlemler paneli gizlenir istatistik paneli gösterilir.
        {
            if (sgmt_urun.SelectedIndex == 0)//XanderUI sınıfından segment aracının seçili değeri 0 ise işlemler panelini(ekleme, silme, güncelleme....) Gösteriyoruz                                                                             
            {
                pnl_istatistik.Hide();
                pnl_islem.Show();
                chrt_enpahalı.Series.Remove(chrt_enpahalı.Series["En Pahalı Ürün"]);//Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoruz.
                chrt_enucuz.Series.Remove(chrt_enucuz.Series["En Ucuz Ürün"]);//Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoruz.
                chrt_tedarik.Series.Remove(chrt_tedarik.Series["Ürün Sayısı"]);//Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoruz.
            }
            else if (sgmt_urun.SelectedIndex == 1)//XanderUI sınıfından segment aracının seçili değeri 1 ise istatistikler panelini gösteriyoruz.
            {
                pnl_islem.Hide();
                pnl_istatistik.Location = pnl_islem.Location;
                pnl_istatistik.Show();
                d.istatistikxy("select U_Ad,U_Satis from TBL_URUN where U_Satis=(select MAX(U_Satis) from TBL_URUN)", chrt_enpahalı, "En Pahalı Ürün");//İstatistikler segmentine geçince db classındaki istatistikxy metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
                d.istatistikxy("select U_Ad,U_Satis from TBL_URUN where U_Satis=(select Min(U_Satis) from TBL_URUN)", chrt_enucuz, "En Ucuz Ürün");//İstatistikler segmentine geçince db classındaki istatistikxy metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
                d.istatistikxy("select t_Ad, count(*) from TBL_URUN inner join TBL_TEDARIKCILER on TBL_URUN.T_No = TBL_TEDARIKCILER.T_No group by T_Ad", chrt_tedarik, "Ürün Sayısı");//İstatistikler segmentine geçince db classındaki istatistikxy metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
            }
        }

        //
        //DataGridView CellClick(Satırlara Tıklayınca Verileri İlgili Textboxlara Taşımak İçin)
        //

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           d.tasima(txt_no, txt_ad, txt_alis, txt_satis, cmbx_kategori, cmbx_tedarik, txt_stok, dataGridView1, e);//db classındaki 'tasima' metodu datagridviewin hücrelerine tıklayınca değerleri ilgili textboxlara taşıma işlemini yapar.
        }
    }
}
