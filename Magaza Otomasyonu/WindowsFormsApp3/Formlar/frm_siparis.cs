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

    public partial class frm_siparis : Form
    {
        db d = new db();
        frm f = new frm();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I6L92IT\SQLEXPRESS03;Initial Catalog=IlkOtomasyon;Integrated Security=True");      //database bağlantısı

        public frm_siparis()
        {
            InitializeComponent();
        }

        //
        //Formun Loadı
        //

        private void frm_siparis_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;//Satış Tarihinde oynama yapılırsa veri kaybı olur diye DateTimePicker ı enabled false yaptım
            error_sno.BlinkStyle = ErrorBlinkStyle.NeverBlink;//ErrorProviderın blink style ayarı
            error_mno.BlinkStyle = ErrorBlinkStyle.NeverBlink;//ErrorProviderın blink style ayarı
            error_uno.BlinkStyle = ErrorBlinkStyle.NeverBlink;//ErrorProviderın blink style ayarı
            ToolTip aciklama = new ToolTip();//Tooltip için nesne türettim
            aciklama.SetToolTip(btn_sifirla, "Aşağıda Yazılı Olan Bilgileri Siler(Herhangi Bir Veri Kaybı Yaşanmaz)");      //textboxların üstündeki küçük butonun açıklaması
            cmbx_ara.SelectedIndex = 0;     //arama kutusunun ilk aşamada seçili gelmesi için
        }

        //
        //Sipariş Ekleme Butonu
        //

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_sno.Text == null || txt_sno.Text == "" || txt_mno.Text == "" || txt_adet.Text == "") //Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                error_sno.SetError(txt_sno, "Bu alan boş geçilemez");//ErrorProvdier İle uyarıyoruz.
                error_mno.SetError(txt_mno, "Bu alan boş geçilemez");//ErrorProvdier İle uyarıyoruz.
                error_uno.SetError(txt_uno, "Bu alan boş geçilemez");//ErrorProvdier İle uyarıyoruz.
            }
            else
            {
                d.prkeykontrol("prkeykontrolsiparis", txt_sno);//Primary key alanına aynı veri iki kere girilmediği için db classındaki prkeykontrol metodu ile alanı kontrol ediyorum
                int a = Convert.ToInt32(d.y);//db classındaki primary key kontorlü için değişken oluşturmuştum onu int veri tipine çeviriyorum.
                if (a == 1)//kayıt etkilendiyse yani kayıt varsa hata mesajı verecek.
                {
                    MessageBox.Show("Lütfen No Alanını Daha Önce Kullanılmamış Bir Değer Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                }
                else
                {
                    d.toplamfiyat(txt_bfiyat, txt_adet, txt_tfiyat);//Sipariş Oluşturulurken 'txt_bfiyat' ve 'txt_adet' alanlarına değer girilince bu değerleri çarpıp 'txt_tfiyat' textbox sına yazdıran metot 'txt_tfiyat textboxı visible özelliği false dır kullanıcı görmez
                    d.eklegunsil("insert into TBL_SIPARIS (S_Tarih, S_No, M_No, S_ToFiyat) values (@p1, @p2, @p3, @p4)", dateTimePicker1, txt_sno, txt_mno, txt_tfiyat); //db classındaki eklegünsil metodu TextBox lara ve DateTimePicker a yazılan değerleri içine gönderdiğim sql kodu ile işleyecek.
                    d.eklegunsil("insert into Siparis_Urun_Detay(adet, U_No, S_No, BFiyat) values(@p1, @p2, @p3, @p4)", txt_adet, txt_uno, txt_sno, txt_bfiyat);//db classındaki eklegünsil metodu textboxlara yazılan değerleri içine gönderdiğim sql kodu ile işleyecek.
                    d.listele("select * from TBL_SIPARIS", dataGridView1);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
                    d.listele("select * from Siparis_Urun_Detay", dataGridView2);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip datagridviewe değer gösterecek
                    MessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//İlgili Mesajı Gösteriyoruz.
                }
               
            }
        }

        //
        //Sipariş Silme Butonu
        //

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (txt_sno.Text == null || txt_sno.Text == "")//Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Sipariş Numarasına Göre Silinme İşlemi Yapılacaktır 'Sipariş No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                error_sno.SetError(txt_sno, "Bu Alan Boş Geçilemez.");//Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.eklegunsil("delete from TBL_SIPARIS where S_No=@p1", txt_sno);//db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod satırı
                if (d.x == 0)//Olmayan bir kaydı silmeyi engelliyoruz.
                {
                    MessageBox.Show("Olmayan Bir Kayıdı Silmeye Çalıştınız. Gerekli Alanları Kontrol Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                    error_sno.SetError(txt_sno, "Bu Alan Boş Geçilemez.");//Errorprovdier ile uyarıyoruz.
                }
                else
                {
                    d.listele("select * from TBL_SIPARIS", dataGridView1);//Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
                    f.sifirla(txt_uno, txt_sno, txt_mno, txt_adet, txt_bfiyat);//frm classındaki 'sifirla' metodu içine parametre olarak verilen textboxları sıfırlar, silme işlemi bittikten sonra textboxları sıfırlıyoruz.
                    MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//İlgili Mesajı Gösteriyoruz.
                }
                d.eklegunsil("delete from Siparis_Urun_Detay where S_No=@p1", txt_sno);//db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod satırı
                d.listele("select * from Siparis_Urun_Detay", dataGridView2);//Hata yok ise db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.

            }
        }

        //
        //Sipariş Listeleme Butonu
        //

        private void btn_listele_Click(object sender, EventArgs e)
        {
            d.listele("select * from TBL_SIPARIS", dataGridView1);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
             d.listele("select * from Siparis_Urun_Detay", dataGridView2);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
        }

        //
        //Textboxları Sıfırlama Butonu
        //

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            f.sifirla(txt_sno, txt_mno, txt_sno, txt_adet, txt_uno, txt_bfiyat);//frm classındaki 'sifirla' metodu içine parametre olarak verilen textboxları sıfırlar, silme işlemi bittikten sonra textboxları sıfırlıyoruz.
        }

        //
        //Sipariş Güncelleme Butonu
        //

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (txt_sno.Text == "" || txt_sno.Text == null) //Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Sipariş Numarasına Göre Güncelleme İşlemi Yapılacaktır 'Sipariş No' Alanını Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                error_sno.SetError(txt_sno, "Bu alan boş geçilemez");//Errorprovdier ile uyarıyoruz.
            }
            else
            {
                d.toplamfiyat(txt_bfiyat, txt_adet, txt_tfiyat);//Sipariş Oluşturulurken 'txt_bfiyat' ve 'txt_adet' alanlarına değer girilince bu değerleri çarpıp 'txt_tfiyat' textbox sına yazdıran metot 'txt_tfiyat textboxı visible özelliği false dır kullanıcı görmez
                d.eklegunsil("update TBL_SIPARIS set M_No=@p2, S_ToFiyat=@p3 where S_No=@p1", txt_sno, txt_mno, txt_tfiyat);//db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod satırı
                d.eklegunsil("update Siparis_Urun_Detay set U_No=@p2, adet=@p3, BFiyat=@p4 where S_No=@p1", txt_sno, txt_uno, txt_adet, txt_bfiyat);//db classındaki eklegünsil metodu ile içine gönderdiğimiz sql cümlesini ilgili textboxdan veriyi alarak çalıştıran kod satırı
                if (d.x == 0)
                    MessageBox.Show("Olmayan Bir Kayıdı Güncellemeye Çalıştınız. Lütfen Dikkat Ediniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                else
                {
                    d.listele("select * from TBL_SIPARIS", dataGridView1);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
                    d.listele("select * from Siparis_Urun_Detay", dataGridView2);//db classındaki listele metodu içine gönderdiğim sql kodunu işleyip ilgili datagridviewe değeri gösterecektir.
                    MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);//İlgili Mesajı Gösteriyoruz.
                }
            }
        }

        //
        //Sipariş Arama Butonu
        //

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_sno.Text == "")//Textboxın boş olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("'Sipariş No' Alanını Kontrol Ediniz Boş Veya Yanlış Değer Girmediğinizden Emin Olun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.
                error_sno.SetError(txt_sno, "Bu alan boş geçilemez");// Errorprovdier ile uyarıyoruz.
            }
            d.ara("select * from TBL_SIPARIS where S_No = @p1", txt_sno, dataGridView1);//db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak No'ya göre arama işlemini gerçekleştiriyor.
            d.ara("select * from Siparis_Urun_Detay where S_No = @p1", txt_sno, dataGridView2);//db classındaki ara metodu içine gönderdiğimiz sql cümlesiyle gerekli textboxdan veriyi alarak No'ya göre arama işlemini gerçekleştiriyor.

        }

        //
        //Bir Sonraki Sipariş İçin Sipariş No Oluştur Butonu
        //

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();        //SqlCommand Sınıfından komut isminde bir nesne türettim
            d.sonproc(komut);//Sipariş Formunda S_No Alanını Otomatik Artma Şeklinde Yapmadığım İçin Otomatik Artmasını Sağlayan Kod Satırı
            txt_sno.Text = komut.Parameters["@deger"].Value.ToString(); //db classındaki 'sonproc' metodunda stored procuder kullanıldığı için oradan dönen değer '@deger' isminde bir değişkende tutuluyor '@deger' değişkeninin değerini stringe çevirerek 'txt_sno' textboxsına yazdırdık.
            baglanti.Close();
            txt_sno.Enabled = false;//başka değer girilmesin diye enabled özelliğini false yaptım
        }

        //-----Error Provdilerin Silinmesi İçin Gerekli Eventler--------
        private void txt_sno_TextChanged(object sender, EventArgs e)
        {
            if (txt_sno.Text != "") // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_sno.Clear();
        }

        private void txt_mno_TextChanged(object sender, EventArgs e)
        {
            if (txt_mno.Text != "") // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_mno.Clear();
        }

        private void txt_uno_TextChanged(object sender, EventArgs e)
        {
            if (txt_uno.Text != "") // ErrorProvdier aracını ilgili textbox boş değilse temizliyoruz.
                error_uno.Clear();
        }
        //----------------------------------------------------------------------------------------

        //----------------- İlgili ToolStrip Öğelerinin Click Eventi-------------------------------------
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
        //----------------------------------------------------------------------------------------

        //
        //İşlemler Ve İstastistikler Arası Geçiş Segmenti
        //

        private void sgmt_siparis_IndexChanged(object sender, EventArgs e)//Burada bir trick kullanılmıştır ilk başta aktif olan işlemler panelidir eğer segment değiştirilirse işlemler paneli gizlenir istatistik paneli gösterilir.
        {
            if (sgmt_siparis.SelectedIndex == 0)//XanderUI sınıfından segment aracının seçili değeri 0 ise işlemler panelini(ekleme, silme, güncelleme....) Gösteriyoruz.
            {
                pnl_istatistik.Hide();
                pnl_islem.Show();
                chrt_tumsiparis.Series.Remove(chrt_tumsiparis.Series["Sipariş Sayısı"]);//Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoru
                chrt_gunsiparis.Series.Remove(chrt_gunsiparis.Series["Sipariş Sayısı"]);//Chart nesnesini istatistiklerde sıkıntı olmasın diye her seferinde siliyoru
            }
            else if (sgmt_siparis.SelectedIndex == 1)
            {
                d.istatistiky("select count(S_No) from TBL_SIPARIS", chrt_tumsiparis, "Sipariş Sayısı");//İstatistikler segmentine geçince db classındaki istatistiky metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
                d.istatistiky("select count(S_No) from TBL_SIPARIS where S_Tarih='"+dateTimePicker1.Text+"'", chrt_gunsiparis, "Sipariş Sayısı");//İstatistikler segmentine geçince db classındaki istatistiky metodu ile içine gönderdiğim sql cümlesi çalışıp ilgili chart aracına değeri gösteriyor.
                pnl_islem.Hide();
                pnl_istatistik.Show();
                pnl_istatistik.Location = pnl_islem.Location;
            }
        }

        //
        //Sipariş Ara Comboboxı SelectedIndexChanged
        //

        private void cmbx_ara_SelectedIndexChanged(object sender, EventArgs e)//Arama İşlemi Yapılırken Kulanıcın kafası karışmasını engellemek amaçlı yapılmıştır. 
        {
            if (cmbx_ara.SelectedIndex == 0)//Comboboxın SelectedIndex 0 Yani 'Seçiniz' ise aşağıdaki işlemler gerçekleştirilecek
            {
                dateTimePicker1.Visible = true;
                txt_mno.Visible = true;
                txt_adet.Visible = true;
                txt_sno.Visible = true;
                txt_uno.Visible = true;
                btn_ekle.Enabled = true;
                btn_guncelle.Enabled = true;
                btn_listele.Enabled = true;
                btn_sil.Enabled = true;
                btn_ara.Enabled = false;
                txt_bfiyat.Visible = true;
            }
            else //Comboboxın SelectedIndex 1 Yani 'No'ya Göre Ara' ise aşağıdaki işlemler gerçekleştirilecek
            {
                dateTimePicker1.Visible = false;
                txt_mno.Visible = false;
                txt_adet.Visible = false;
                txt_sno.Visible = true;
                txt_uno.Visible = false;
                btn_ara.Enabled = true;
                btn_ekle.Enabled = false;
                btn_guncelle.Enabled = false;
                btn_listele.Enabled = false;
                btn_sil.Enabled = false;
                txt_bfiyat.Visible = false;
                txt_sno.Enabled = true;
            }
        }

        //
        //DataGridView CellClick(Satırlara Tıklayınca Verileri İlgili Textboxlara Taşımak İçin)
        //

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                d.tasima(txt_sno, txt_mno, dateTimePicker1, dataGridView1, e);//db classındaki 'tasima' metodu datagridviewin hücrelerine tıklayınca değerleri ilgili textboxlara taşıma işlemini yapar.
                d.tasi(txt_sno, txt_uno, txt_adet, txt_mno,txt_bfiyat);//datagridviewdeki satıra tıklayınca veriyi ilgili textboxa taşımak için yazılmıştır ama bu metotta stored procedure kullanılmıştır. stored procedure kullanma amacım ise 'Siparis_Urun_Detay' tablosunda bulunmayan M_No,S_ToFiyat ve S_Tarih kolonları 'TBL_SIPARIS' Tablosunda herhangi bir satıra tıklayınca gelmiyor. Bu sorunu çözmek için yazdım
            }
            catch (Exception)
            {
            }
        }

        //
        //DataGridView CellClick(Satırlara Tıklayınca Verileri İlgili Textboxlara Taşımak İçin)
        //

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                d.tasima(txt_uno, txt_sno, txt_adet, txt_bfiyat, dataGridView2, e);//db classındaki 'tasima' metodu datagridviewin hücrelerine tıklayınca değerleri ilgili textboxlara taşıma işlemini yapar.
                d.tasi(txt_sno, txt_uno, txt_adet, txt_mno, txt_bfiyat);//datagridviewdeki satıra tıklayınca veriyi ilgili textboxa taşımak için yazılmıştır ama bu metotta stored procedure kullanılmıştır. stored procedure kullanma amacım ise 'Siparis_Urun_Detay' tablosunda bulunmayan M_No,S_ToFiyat ve S_Tarih kolonları 'TBL_SIPARIS' Tablosunda herhangi bir satıra tıklayınca gelmiyor. Bu sorunu çözmek için yazdım
            }
            catch (Exception)
            {

                
            }
           
        }
    }
}