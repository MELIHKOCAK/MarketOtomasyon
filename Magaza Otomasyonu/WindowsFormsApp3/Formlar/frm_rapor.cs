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

namespace WindowsFormsApp3.Formlar
{
    public partial class frm_rapor : Form
    {
        public frm_rapor()
        {
            InitializeComponent();
        }

        melihkocak0385.db d = new melihkocak0385.db();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I6L92IT\SQLEXPRESS03;Initial Catalog=IlkOtomasyon;Integrated Security=True");          // Veri Tabanı Bağlantısı

        //
        //Formun Loadı
        //

        private void frm_rapor_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;//veritabanına rapordan dolayı sorgu göndermek için datetimepickerın formatı değiştirildi
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";//DateTimePicker e gerekli değer verildi
            dateTimePicker2.CustomFormat = "yyyy.MM.dd";
            txt_min.Enabled = false;//Ürün TabPage Sekmesinde fiyat aralığı girmeyi zorunlu tutmadığım için, ilk başta enabled özelliğini false yaptım
            txt_max.Enabled = false;
            ToolTip aciklama = new ToolTip();//tooltip için nesne türettim
            aciklama.SetToolTip(chbox_uonay, "İşaretlendiği Zaman Fiyat Aralığıda Girebilirsiniz."); //Ürün alanındaki checkbox için açıklama
            aciklama.SetToolTip(chbox_sonay, "İşaretlendiği Zaman Müşteri Numarasıda Girebilirsiniz.");//Sipariş alanındaki checkbox için açıklama
            aciklama.SetToolTip(grpbox_mbilgi, "İki Değer Arasında Olan Müşteri Bilgilerini Getirir.");
            aciklama.SetToolTip(txt_mmin, "Küçük Değer");
            aciklama.SetToolTip(txt_mmax, "Büyük Değer");
            aciklama.SetToolTip(txt_kmin, "Küçük Değer");//Fiyat yada no alanlarını girerken aralık vermek için textbox kullanıldı hangi textboxın küçük büyük değeri ifade ettiği anlaşılsın diye tooltip eklendi
            aciklama.SetToolTip(txt_kmax, "Büyük Değer");
            aciklama.SetToolTip(txt_tmin, "Küçük Değer");
            aciklama.SetToolTip(txt_tmax, "Büyük Değer");
            aciklama.SetToolTip(txt_min, "Küçük Değer");
            aciklama.SetToolTip(txt_max, "Büyük Değer");
            cmbx_uara.SelectedIndex = 0;
            cmbx_mara.SelectedIndex = 0;//ComboBoxlarda ilk değer seçili gelmesi için böyle yapıldı.
            cmbx_tara.SelectedIndex = 0;
            cmbx_kara.SelectedIndex = 0;
        }

        //
        //Sipariş Rapor Butonu
        //

        private void btn_raporSiparis_Click(object sender, EventArgs e)
        {
            Rapor.siparis s = new Rapor.siparis();//'siparis' Sınıfından(CrystalReportta oluşturduğum sınıf) nesne türettim
            if (chbox_sonay.Checked==true && txt_mno.Text=="")//Sipariş TabPage Sekmesinde Müşteri No girmek için CheckBox işaretlendiyse fakat girilmeyip 'Raporla' butonuna basılırsa hata verir.
                MessageBox.Show("Lütfen Müşteri Numarasını Giriniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (chbox_sonay.Checked==true && txt_mno.Text != "")//Sipariş TabPage Sekmesinde Müşteri No girmek için CheckBox işaretlendip değer girildiyse ardından 'Raporla' butonuna basılırsa müşterinin belirlenen tarihlerdeki siparişleri rapora sunulur.
                d.rapor("select S_Tarih, b.M_No, U_Ad, c.U_No, Adet, BFiyat, S_ToFiyat, M_Ad, M_Soyad, M_Tel from TBL_SIPARIS a, TBL_MUSTERİ b, Siparis_Urun_Detay c, TBL_URUN d where a.S_No=c.S_No  and b.M_No = " + txt_mno.Text + "and   b.M_No=a.M_No and c.U_No = d.U_no and a.S_Tarih  BETWEEN'" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'", s, crystalReportViewer1);

            else if(chbox_sonay.Checked==false)//Sipariş TabPage Sekmesinde Müşteri No girmek için olan CheckBox işaretlenmediyse bu sefer sadece belirlediğimiz tarihler arasındaki müşteri numarası farketmeksizin bütün siparişleri getirir.
                d.rapor("select S_Tarih, b.M_No, U_Ad, c.U_No, Adet, BFiyat, S_ToFiyat, M_Ad, M_Soyad, M_Tel from TBL_SIPARIS a, TBL_MUSTERİ b, Siparis_Urun_Detay c, TBL_URUN d where a.S_No=c.S_No and   b.M_No=a.M_No and c.U_No = d.U_no and a.S_Tarih  BETWEEN'" + dateTimePicker1.Text + " ' AND ' " + dateTimePicker2.Text + "'", s, crystalReportViewer1);
        }

        //
        //Ürün Rapor Butonu
        //

        private void btn_raporUrun_Click(object sender, EventArgs e)
        {
            Rapor.urun u = new Rapor.urun();//'urun' Sınıfından(CrystalReportta oluşturduğum sınıf) nesne türettim
            if (cmbx_uara.SelectedIndex==0 && chbox_uonay.Checked==false)//Ürün TabPage Sekmesinde ComboBoxda herhangi bir filtreleme işlemi yapılmadıysa ve Kullanıcın fiyat aralığı girebilecek olan CheckBox aktif hale getirilmediyse hata mesajı verir.
                MessageBox.Show("Lütfen Filtreleme Yapınız Veya Fiyat Aralığı Giriniz.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_uara.SelectedIndex == 0 && chbox_uonay.Checked == true && txt_min.Text == "" && txt_max.Text == "")//Ürün TabPage Sekmesinde ComboBoxda herhangi bir filtreleme işlemi yapılmadıysa ama kullanıcın fiyat aralığı girebileceği CheckBox aktif hale getirilip fiyat girilmediyse hata mesajı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_uara.SelectedIndex == 0 && chbox_uonay.Checked==true && txt_min.Text != "" && txt_max.Text != "")//Ürün TabPage Sekmesinde ComboBoxda herhangi bir filtreleme işlemi yapılmadıysa ama kullanıcın fiyat aralığı girebileceği CheckBox aktif hale getirildiyse ve İlgili textboxlarda fiyat değerleri yazıyorsa o fiyat aralığındaki ürünler rapora işlenir.
                d.rapor("Select U_No, U_Ad, U_Alis, U_Satis, K_Ad, T_Ad from TBL_URUN u, TBL_KATEGORI k, TBL_TEDARIKCILER t WHERE u.K_No = k.K_No  AND U_Satis BETWEEN " + txt_min.Text + " AND " + txt_max.Text + " AND t.T_No=u.T_No", u, crystalReportViewer1);

            else if (cmbx_uara.SelectedIndex == 1 && chbox_uonay.Checked == true && txt_min.Text == "" && txt_max.Text == "")
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_uara.SelectedIndex==1 && chbox_uonay.Checked == true && txt_min.Text != "" && txt_max.Text != "" && txt_uno.Text!="")//Ürün TabPage Sekmesinde ComboBox aracının SelectedIndex değeri 1 olduysa yani 'Tedarikçi No'ya Göre Raporla' kısmı seçili ise ve Ürünlerin fiyatlarını girebileceğimiz yeri aktif eden CheckBox İşaretlendiyse 'txt_min', 'txt_max', 'txt_uno' alanları boş değilse 
                //Bizim belirlediğimiz tedarikçinin yine bizim belirlediğimiz fiyat aralığındaki ürünleri listeleyecektir. sanırım bu yorum çok uzun oldu:)
                d.rapor("Select U_No, U_Ad, U_Alis, U_Satis, K_Ad, T_Ad from TBL_URUN u, TBL_KATEGORI k, TBL_TEDARIKCILER t WHERE u.K_No = k.K_No  AND U_Satis BETWEEN " + txt_min.Text + " AND " + txt_max.Text + " AND t.T_No = " + txt_uno.Text + " AND t.T_No=u.T_No", u, crystalReportViewer1);

            else if (cmbx_uara.SelectedIndex == 1 && chbox_uonay.Checked == false && txt_uno.Text == "")//Ürün TabPage Sekmesinde filtreleme ComboBoxın birinci değeri seçili ise ve fiyat aralığın belirttiğimiz yeri aktif eden CheckBox işaretlenmediyse ve 'txt_uno' kısmı boş ise hata mesajı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_uara.SelectedIndex == 1 && chbox_uonay.Checked == false && txt_uno.Text !="")//Ürün TabPage Sekmesinde filtreleme ComboBoxın birinci değeri seçili ise ve fiyat aralığın belirttiğimiz yeri aktif eden CheckBox işaretlendiyse ve 'txt_uno' boş değilse Bizim belirlediğimiz tedarikçinin bütün ürünleri rapora işlenir.
                d.rapor("Select U_No, U_Ad, U_Alis, U_Satis, K_Ad, T_Ad from TBL_URUN u, TBL_KATEGORI k, TBL_TEDARIKCILER t WHERE  u.T_No = " + txt_uno.Text + " AND u.K_No = k.K_No and u.T_No=t.T_No", u, crystalReportViewer1);

            else if (cmbx_uara.SelectedIndex == 2 && chbox_uonay.Checked == true && txt_min.Text == "" && txt_max.Text == "" && txt_uno.Text == "")//Ürün TabPage Sekmesinde filtreleme ComboBoxın İkinci değeri seçili ise ve fiyat aralığın belirttiğimiz yeri aktif eden CheckBox işaretlendiyse ama 'txt_min', 'txt_max', 'txt_uno' alanları boş ise hata mesahı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_uara.SelectedIndex == 2 && chbox_uonay.Checked == true && txt_min.Text != "" && txt_max.Text != "" && txt_uno.Text != "")//Ürün TabPage Sekmesinde ComboBox aracının SelectedIndex değeri 2 olduysa yani 'Kategori No'ya Göre Raporla' kısmı seçili ise ve Ürünlerin fiyatlarını girebileceğimiz yeri aktif eden CheckBox İşaretlendiyse 'txt_min', 'txt_max', 'txt_uno' alanları boş değilse 
                //Bizim belirlediğimiz kategorinin yine bizim belirlediğimiz fiyat aralığındaki ürünleri listeleyecektir. sanırım bu yorumda çok uzun oldu:)
                d.rapor("Select U_No, U_Ad, U_Alis, U_Satis, K_Ad, T_Ad from TBL_URUN u, TBL_KATEGORI k, TBL_TEDARIKCILER t WHERE k.K_No =" + txt_uno.Text + " AND U_Satis BETWEEN " + txt_min.Text + " AND " + txt_max.Text + " AND t.t_No=u.t_No AND k.K_No = u.K_No", u, crystalReportViewer1);

            else if (cmbx_uara.SelectedIndex == 2 && chbox_uonay.Checked == false && txt_uno.Text == "")//Ürün TabPage Sekmesinde filtreleme ComboBoxın ikinci değeri seçili ise ve fiyat aralığın belirttiğimiz yeri aktif eden CheckBox işaretlenmediyse ve 'txt_uno' kısmı boş ise hata mesajı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_uara.SelectedIndex == 2 && chbox_uonay.Checked == false && txt_uno.Text != "")//Ürün TabPage Sekmesinde filtreleme ComboBoxın ikinci değeri seçili ise ve fiyat aralığın belirttiğimiz yeri aktif eden CheckBox işaretlendiyse ve 'txt_uno' boş değilse Bizim belirlediğimiz kategorinin bütün ürünleri rapora işlenir.
                d.rapor("Select U_No, U_Ad, U_Alis, U_Satis, K_Ad, T_Ad from TBL_URUN u, TBL_KATEGORI k, TBL_TEDARIKCILER t WHERE  t.T_No = u.T_No AND k.K_No =" + txt_uno.Text + " AND k.K_No=u.K_No", u, crystalReportViewer1);

        }

        //
        //Müşteri Rapor Butonu
        //

        private void btn_musteriRapor_Click(object sender, EventArgs e)
        {
            Rapor.musteri m = new Rapor.musteri();//'musteri' Sınıfından(CrystalReportta oluşturduğum sınıf) nesne türettim
            if (cmbx_mara.SelectedIndex == 0)//Herhangi bir filtremele işlemi seçilmediyse hata mesajı verir.
                MessageBox.Show("Lütfen Filtrede Bir Seçenek Seçiniz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_mara.SelectedIndex == 1 && txt_mmin.Text == "" && txt_mmax.Text == "")//Müşteri TabPage sekmesinin filtreleme ComboBox aracının birinci değeri seçili ise yani 'Müşteri No'ya Göre Raporla' kısmı seçili ise ama 'Müşteri No' aralığı vereceğimiz alanlar boş ise hata mesajı verir
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_mara.SelectedIndex == 1 && txt_mmin.Text != "" && txt_mmax.Text != "")//Müşteri TabPage sekmesinin filtreleme ComboBox aracının birinci değeri seçili ise yani 'Müşteri No'ya Göre Raporla' kısmı seçili ve 'Müşteri No' aralığını vereceğimiz alanlar boş değilse bizim belirlediğimiz alanlardaki bütün müşteriler rapora işlenir.
                d.rapor("select M_No, M_Ad, M_Soyad, M_Tel, M_Mail from TBL_MUSTERİ where M_No BETWEEN " + txt_mmin.Text + " AND " + txt_mmax.Text, m, crystalReportViewer1);

            else if (cmbx_mara.SelectedIndex == 2 && txt_mad.Text == "")//Müşteri TabPage sekmesinin filtreleme ComboBox aracının ikinci değeri seçili ise yani 'Müşteri Ad'a Göre Raporla' kısmı seçili ise ama müşteri adı vereceğimiz TextBox boş ise hata mesajı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_mara.SelectedIndex == 2 && txt_mad.Text != "")//Müşteri TabPage sekmesinin filtreleme ComboBox aracının ikinci değeri seçili ise yani 'Müşteri Ad'a Göre Raporla' kısmı seçili ise ama müşteri adı vereceğimiz TextBox boş değilse bizim belirlediğimiz ada uyan Müşteriler rapora işlenir.
                d.rapor("select M_No, M_Ad, M_Soyad, M_Tel, M_Mail from TBL_MUSTERİ where M_Ad Like '%" + txt_mad.Text + "%'", m, crystalReportViewer1);

        }

        //
        //Tedarikçi Rapor Butonu
        //

        private void btn_tedarikRapor_Click(object sender, EventArgs e)
        {
            Rapor.tedarikci t = new Rapor.tedarikci();//'tedarikci' Sınıfından(CrystalReportta oluşturduğum sınıf) nesne türettim
            if (cmbx_tara.SelectedIndex == 0)//Herhangi bir filtremele işlemi seçilmediyse hata mesajı verir.
                MessageBox.Show("Lütfen Filtrede Bir Seçenek Seçiniz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if(cmbx_tara.SelectedIndex == 1 && txt_tmin.Text == "" && txt_tmax.Text == "")//Tedarikçi TabPage sekmesinin filtreleme ComboBox aracının birinci değeri seçili ise yani 'Tedarikçi No'ya Göre Raporla' kısmı seçili ise ama 'Tedarikçi No' aralığı vereceğimiz alanlar boş ise hata mesajı verir
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_tara.SelectedIndex == 1 && txt_tmin.Text != "" && txt_tmax.Text != "")//Tedarikçi TabPage sekmesinin filtreleme ComboBox aracının birinci değeri seçili ise yani 'Tedarikçi No'ya Göre Raporla' kısmı seçili ve 'Tedarikçi No' aralığını vereceğimiz alanlar boş değilse bizim belirlediğimiz alanlardaki bütün Tedarikçiler rapora işlenir.
                d.rapor("select T_No, T_Ad, T_Adres, T_Tel, T_Mail from TBL_TEDARIKCILER where T_No BETWEEN " + txt_tmin.Text + " AND " + txt_tmax.Text, t, crystalReportViewer1);

            else if (cmbx_tara.SelectedIndex == 2 && txt_tad.Text == "")//Tedarikçi TabPage sekmesinin filtreleme ComboBox aracının ikinci değeri seçili ise yani 'Tedarikçi Ad'a Göre Raporla' kısmı seçili ise ama Tedarikçi adı vereceğimiz TextBox boş ise hata mesajı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);//İlgili Mesajı Gösteriyoruz.

            else if (cmbx_tara.SelectedIndex == 2 && txt_tad.Text != "")//Tedarikçi TabPage sekmesinin filtreleme ComboBox aracının ikinci değeri seçili ise yani 'Tedarikçi Ad'a Göre Raporla' kısmı seçili ise ama Tedarikçi adı vereceğimiz TextBox boş değilse bizim belirlediğimiz ada uyan Tedarikçiler rapora işlenir.
                d.rapor("select T_No, T_Ad, T_Adres, T_Tel, T_Mail from TBL_TEDARIKCILER where T_Ad Like '%" + txt_tad.Text + "%'", t, crystalReportViewer1);
        }

        //
        //Kategori Rapor Butonu
        //

        private void btn_kategoriRapor_Click(object sender, EventArgs e)
        {
            Rapor.kategori k = new Rapor.kategori();//'kategori' Sınıfından(CrystalReportta oluşturduğum sınıf) nesne türettim
            if (cmbx_kara.SelectedIndex == 0)//Herhangi bir filtremele işlemi seçilmediyse hata mesajı verir.
                MessageBox.Show("Lütfen Filtrede Bir Seçenek Seçiniz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (cmbx_kara.SelectedIndex == 1 && txt_kmin.Text == "" && txt_kmax.Text == "")//Kategori TabPage sekmesinin filtreleme ComboBox aracının birinci değeri seçili ise yani 'Kategori No'ya Göre Raporla' kısmı seçili ise ama 'Kategori No' aralığı vereceğimiz alanlar boş ise hata mesajı verir
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (cmbx_kara.SelectedIndex == 1 && txt_kmin.Text != "" && txt_kmax.Text != "")//Kategori TabPage sekmesinin filtreleme ComboBox aracının birinci değeri seçili ise yani 'Kategori No'ya Göre Raporla' kısmı seçili ve 'Kategori No' aralığını vereceğimiz alanlar boş değilse bizim belirlediğimiz alanlardaki bütün Kategori rapora işlenir.
                d.rapor("select K_No, K_Ad from TBL_KATEGORI where K_No between " + txt_kmin.Text + " AND " + txt_kmax.Text, k, crystalReportViewer1);

            else if (cmbx_kara.SelectedIndex == 2 && txt_kad.Text == "")//Kategori TabPage sekmesinin filtreleme ComboBox aracının ikinci değeri seçili ise yani 'Kategori Ad'a Göre Raporla' kısmı seçili ise ama Kategori adı vereceğimiz TextBox boş ise hata mesajı verir.
                MessageBox.Show("Lütfen Gerekli Değerleri Doldurunuz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (cmbx_kara.SelectedIndex == 2 && txt_kad.Text != "")//Kategori TabPage sekmesinin filtreleme ComboBox aracının ikinci değeri seçili ise yani 'Kategori Ad'a Göre Raporla' kısmı seçili ise ama Kategori adı vereceğimiz TextBox boş değilse bizim belirlediğimiz ada uyan Kategori rapora işlenir.
                d.rapor("select K_No, K_Ad from TBL_KATEGORI where K_Ad like '%" + txt_kad.Text + "%'", k, crystalReportViewer1);
        }

//--------------------Comboboxların SelectedIndexChanged Eventleri--------------------------------------
        private void cmbx_tara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_tara.SelectedIndex == 0)//ComboBoxın SelectedIndex değeri 0 ise yani 'Seçiniz' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_tbilgi.Visible = false;
                grpbox_tebilgi.Visible = false;
            }
            else if (cmbx_tara.SelectedIndex == 1)//ComboBoxın SelectedIndex değeri 1 ise yani 'Müşteri No'ya Göre Raporla' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_tbilgi.Visible = true;
                grpbox_tebilgi.Visible = false;
            }
            else if (cmbx_tara.SelectedIndex == 2)//ComboBoxın SelectedIndex değeri 2 ise yani 'Müşteri Ad'a Göre Raporla' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_tbilgi.Visible = false;
                grpbox_tebilgi.Location = new Point(137, 3);
                grpbox_tebilgi.Visible = true;

            }
        }//Tedarikçi TabPage Sekmesinde filtreleme için kullandım.

        private void cmbx_mara_SelectedIndexChanged(object sender, EventArgs e)//Müşteri TabPage Sekmesinde filtreleme için kullandım.
        {
            if (cmbx_mara.SelectedIndex == 0)//ComboBoxın SelectedIndex değeri 0 ise yani 'Seçiniz' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_mad.Visible = false;
                grpbox_mbilgi.Visible = false;
            }
            else if (cmbx_mara.SelectedIndex == 1)//ComboBoxın SelectedIndex değeri 2 ise yani 'Müşteri No'ya Göre Raporla' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_mbilgi.Visible = true;
                grpbox_mad.Visible = false;
            }
            else if (cmbx_mara.SelectedIndex == 2)//ComboBoxın SelectedIndex değeri 2 ise yani 'Müşteri Ad'a Göre Raporla' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_mbilgi.Visible = false;
                grpbox_mad.Location = new Point(137, 3);
                grpbox_mad.Visible = true;
            }
        }

        private void cmbx_kara_SelectedIndexChanged(object sender, EventArgs e)//Kategori TabPage Sekmesinde filtreleme için kullandım.
        {
            if (cmbx_kara.SelectedIndex == 0)//ComboBoxın SelectedIndex değeri 0 ise yani 'Seçiniz' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_kbilgi.Visible = false;
                grpbox_kabilgi.Visible = false;
            }
            else if (cmbx_kara.SelectedIndex == 1)//ComboBoxın SelectedIndex değeri 1 ise yani 'Kategori No'ya Göre Raporla' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_kbilgi.Visible = true;
                grpbox_kabilgi.Visible = false;
            }
            else if (cmbx_kara.SelectedIndex == 2)//ComboBoxın SelectedIndex değeri 2 ise yani 'Kategori Ad'a Göre Raporla' Kısmında ise olaylar gerçekleşecektir.
            {
                grpbox_kbilgi.Visible = false;
                grpbox_kabilgi.Location = new Point(137, 3);
                grpbox_kabilgi.Visible = true;
            }
        }

        private void cmbx_uara_SelectedIndexChanged(object sender, EventArgs e)//Ürün TabPage Sekmesinde filtreleme için kullandım.
        {
            if (cmbx_uara.SelectedIndex == 0)//ComboBoxın SelectedIndex değeri 0 ise yani 'Seçiniz' Kısmında ise olaylar gerçekleşecektir.
            {
                txt_uno.Text = "";
                txt_uno.Enabled = false;
            }
            else if (cmbx_uara.SelectedIndex == 1)//ComboBoxın SelectedIndex değeri 1 ise yani 'Tedarikçi' Kısmında ise olaylar gerçekleşecektir.
                txt_uno.Enabled = true;

            else if (cmbx_uara.SelectedIndex == 2)//ComboBoxın SelectedIndex değeri 2 ise yani 'Kategori' Kısmında ise olaylar gerçekleşecektir.
                txt_uno.Enabled = true;
        }
//------------------------------------------------------------------------------------------------------

//------------------------Checkboxların CheckChanged Eventi---------------------------------------------
        private void chck_sonay_CheckedChanged(object sender, EventArgs e)//Sipariş TabPage sekmesinde müşteri numarasına görede raporlama yapmak istenirse diye kullandım.
        {
            if (chbox_sonay.Checked == true)
                txt_mno.Enabled = true;
            else if (chbox_sonay.Checked == false)
            {
                txt_mno.Enabled = false;
                txt_mno.Text = "";
            }
        }

        private void chbox_uonay_CheckedChanged(object sender, EventArgs e)//Ürün TabPage sekmesinde fiyat aralığını aktif etmek için kullandım. 
        {
            if (chbox_uonay.Checked == true)
            {
                txt_min.Enabled = true;
                txt_max.Enabled = true;
            }
            else
            {
                txt_min.Enabled = false;
                txt_max.Enabled = false;
            }
        }
//------------------------------------------------------------------------------------------------------

//--------TextBoxlara Yanlış Veri Girişini Engellemek İçin Gerekli Eventler-----------------------------
        private void txt_uno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_mno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_mmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_mmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_tmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_tmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_kmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_kmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_kad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_tad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.

        private void txt_mad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }//Veri Tabanındaki alanlara yanlış veri girişi sonucunda hata çıkmasını engellemek için bu kod yazıldı. Sadece Numerik ifadelere izin veriyor.
         //------------------------------------------------------------------------------------------------------
    }
}
