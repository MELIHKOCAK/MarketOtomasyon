using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace melihkocak0385
{
    public class db
    {
        public int x;           // Kullanıcı olmayan Kayıtla İlgili İşlem Yaparsa Engellemek İçin Yöntem Kullandım Ondan Dolayı Global Alanda Değişken Tanımladım.
        public string y;           //Primary key kontrolü için global alan değişken tanımlamam gerekti.

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I6L92IT\SQLEXPRESS03;Initial Catalog=IlkOtomasyon;Integrated Security=True");          // Veri Tabanı Bağlantısı


        //5 Adet kolonlu tabloları datagridview nesnesinden ilgili textboxlara taşımak için yazılan metotdur.
        public void tasima(TextBox no, TextBox birinci, TextBox ikinci, TextBox ucuncu, TextBox dorduncu, DataGridView f, DataGridViewCellEventArgs e)
        {
            try                                                                 //DataGridView'in Header Alanına Tıklayınca Doğal Olarak Hata Veriyordu Bu Sorun 'Try Catch' Blokları İle Çözülmüştür.
            {
                no.Text = f.Rows[e.RowIndex].Cells[0].Value.ToString();         //Dışarıdan girilen 'no' textbox nesnesine datagridviewin ilgili satırındaki 0. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
                birinci.Text = f.Rows[e.RowIndex].Cells[1].Value.ToString();
                ikinci.Text = f.Rows[e.RowIndex].Cells[2].Value.ToString();
                ucuncu.Text = f.Rows[e.RowIndex].Cells[3].Value.ToString();
                dorduncu.Text = f.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            { 
            }
        }

        //4 Adet kolonlu tabloları datagridview nesnesinden ilgili textboxlara taşımak için yazılan metotdur.
        public void tasima(TextBox no, TextBox birinci, TextBox ikinci, TextBox ucuncu, DataGridView f, DataGridViewCellEventArgs e)
        {
            try                                                                 //DataGridView'in Header Alanına Tıklayınca Doğal Olarak Hata Veriyordu Bu Sorun 'Try Catch' Blokları İle Çözülmüştür.
            {
                no.Text = f.Rows[e.RowIndex].Cells[0].Value.ToString();         //Dışarıdan girilen 'no' textbox nesnesine datagridviewin ilgili satırındaki 0. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
                birinci.Text = f.Rows[e.RowIndex].Cells[1].Value.ToString();
                ikinci.Text = f.Rows[e.RowIndex].Cells[2].Value.ToString();
                ucuncu.Text = f.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        //7 Adet kolonlu tabloları datagridview nesnesinden ilgili textboxlara ve comboboxlara taşımak için yazılan metotdur.
        public void tasima(TextBox no, TextBox birinci, TextBox ikinci, TextBox ucuncu, ComboBox dorduncu, ComboBox besinci, TextBox altinci, DataGridView f, DataGridViewCellEventArgs e)
        {
            try                                                                 //DataGridView'in Header Alanına Tıklayınca Doğal Olarak Hata Veriyordu Bu Sorun 'Try Catch' Blokları İle Çözülmüştür.     
            {
                no.Text = f.Rows[e.RowIndex].Cells[0].Value.ToString();         //Dışarıdan girilen 'no' textbox nesnesine datagridviewin ilgili satırındaki 0. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
                birinci.Text = f.Rows[e.RowIndex].Cells[1].Value.ToString();
                ikinci.Text = f.Rows[e.RowIndex].Cells[2].Value.ToString();
                ucuncu.Text = f.Rows[e.RowIndex].Cells[3].Value.ToString();
                dorduncu.Text = f.Rows[e.RowIndex].Cells[4].Value.ToString();   //Dışarıdan girilen 'birincii' combobox nesnesine datagridviewin ilgili satırındaki 4. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
                besinci.Text = f.Rows[e.RowIndex].Cells[5].Value.ToString();
                altinci.Text = f.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        //3 Adet kolonlu tabloları datagridview nesnesinden ilgili textboxlar a ve datetimepicker e taşımak için yazılan metotdur.
        public void tasima(TextBox no, TextBox birinci, DateTimePicker date, DataGridView f, DataGridViewCellEventArgs e)
        {
            try
            {
                no.Text = f.Rows[e.RowIndex].Cells[0].Value.ToString();         //Dışarıdan girilen 'no' textbox nesnesine datagridviewin ilgili satırındaki 0. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
                birinci.Text = f.Rows[e.RowIndex].Cells[2].Value.ToString();
                date.Text = f.Rows[e.RowIndex].Cells[1].Value.ToString();       //Dışarıdan girilen 'date' DateTimePicker nesnesine datagridviewin ilgili satırındaki 0. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
            }
            catch (Exception)
            {
            }
        }

        //2 Adet kolonlu tabloları datagridview nesnesinden ilgili textboxlara  taşımak için yazılan metotdur.
        public void tasima(TextBox no, TextBox birinci, DataGridView f, DataGridViewCellEventArgs e)
        {
            try
            {
                no.Text = f.Rows[e.RowIndex].Cells[0].Value.ToString();         //Dışarıdan girilen 'no' textbox nesnesine datagridviewin ilgili satırındaki 0. alanda bulunan hücrenin değerini alır string formatına çevirerek aktarır.
                birinci.Text = f.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        //2 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur.
        public void eklegunsil(string sqlcumle,TextBox no,TextBox birinci)
        {  
            baglanti.Open();                                                      //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);               //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                      //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım.
            komut.Parameters.AddWithValue("@p2", birinci.Text);
            x = komut.ExecuteNonQuery();                                //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.                                    
            baglanti.Close();                                                //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //3 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur.
        public void eklegunsil(string sqlcumle, TextBox no, TextBox birinci, TextBox ikinci)
        {
            baglanti.Open();                                                     //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);              //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                     //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım. 
            komut.Parameters.AddWithValue("@p2", birinci.Text);
            komut.Parameters.AddWithValue("@p3", ikinci.Text);
            x = komut.ExecuteNonQuery();                              //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.
            baglanti.Close();                                            //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //4 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur.
        public void eklegunsil(string sqlcumle, TextBox no, TextBox birinci, TextBox ikinci, TextBox ucuncu)
        {
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);             //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                    //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım. 
            komut.Parameters.AddWithValue("@p2", birinci.Text);
            komut.Parameters.AddWithValue("@p3", ikinci.Text);
            komut.Parameters.AddWithValue("@p4", ucuncu.Text);
            x = komut.ExecuteNonQuery();                            //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.
            baglanti.Close();                                            //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //5 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur.
        public void eklegunsil(string sqlcumle, TextBox no, TextBox birinci, TextBox ikinci, TextBox ucuncu, TextBox dorduncu) 
        {
            baglanti.Open();                                                     //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);              //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                     //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım). 
            komut.Parameters.AddWithValue("@p2", birinci.Text);
            komut.Parameters.AddWithValue("@p3", ikinci.Text);
            komut.Parameters.AddWithValue("@p4", ucuncu.Text);
            komut.Parameters.AddWithValue("@p5", dorduncu.Text);
            x = komut.ExecuteNonQuery();                             //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.
            baglanti.Close();                                            //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //6 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur.
        public void eklegunsil(string sqlcumle, TextBox no, TextBox birinci, TextBox ikinci, TextBox ucuncu, ComboBox birincii, ComboBox ikincii, TextBox altinci)
        {
            baglanti.Open();                                                     //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);              //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                     //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım. 
            komut.Parameters.AddWithValue("@p2", birinci.Text);
            komut.Parameters.AddWithValue("@p3", ikinci.Text);
            komut.Parameters.AddWithValue("@p4", ucuncu.Text);
            komut.Parameters.AddWithValue("@p5", birincii.SelectedValue);
            komut.Parameters.AddWithValue("@p6", ikincii.SelectedValue);
            komut.Parameters.AddWithValue("@p7", altinci.Text);
            x = komut.ExecuteNonQuery();                           //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.
            baglanti.Close();                                            //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //1 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur.
        public void eklegunsil(string sqlcumle, TextBox no)
        {
            
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);             //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                    //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım. 
            x = komut.ExecuteNonQuery();                                     //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.
            baglanti.Close();                                               //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //3 Adet Kolonlu Tablolarda Kayıt Güncellemek, Kayıt Eklemek, Kayıt Silmek İçin Yazılan Metotdur(DateTimePicker Barındırır.)
        public void eklegunsil(string sqlcumle, DateTimePicker tarih, TextBox birinci, TextBox ikinci, TextBox ucuncu)
        {
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);             //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", tarih.Text);                 //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım. 
            komut.Parameters.AddWithValue("@p2", birinci.Text);
            komut.Parameters.AddWithValue("@p3", ikinci.Text);
            komut.Parameters.AddWithValue("@p4", ucuncu.Text);
            x = komut.ExecuteNonQuery();                            //ExecuteNonQuery Komutu Gerekli Kodları Aynı SSMS deki Queryi Execute Etmeye Yarar.
            baglanti.Close();                                            //Veri Tabanı Bağlantısı Kapatıyoruz.
        }

        //Gerekli Forumlarda Kayıt Arama İşlemi Gerçekleştirmek İçin Kullanılan Metotdur.
        public void ara(string sqlcumle, TextBox no, DataGridView a)
        {
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açıyoruz.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);             //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            komut.Parameters.AddWithValue("@p1", no.Text);                    //SQL Cümlesinde Kullandığım Parametreleri İlgili Textbox Nesnelerinden Gelen Değerleri AddWithValue Metodu İle Yazdırdım.
            SqlDataAdapter da = new SqlDataAdapter(komut);                   //SqlDataAdapter Sınıfından da Adında Nesne Türettim Ve İçine Komut Nesnesi Gönderdimki Komut Nesnemizi Uyarlasın.
            DataTable dt = new DataTable();                                 //DataTable Sınıfından dt Adında Nesne Türettim.
            da.Fill(dt);                                                   //DataAdapter Nesnesinden Türettiğim Nesneyi Fill Metodu İle İçine dt Nesnesini Göndererek Doldurdum. 
            a.DataSource = dt;                                            //DataGridView Nesnesinin Veri Kaynağını dt Nesnesine Eşitledim.
            komut.ExecuteNonQuery();                                     //Gerekli Komutları ExecuteNonQuery Komutu İle Çalıştırdım.
            baglanti.Close();                                           //Veri Tabanı Bağlantısını Kapattım
        }

        //Bütün Formlarda Kayıtları Listelemek Amaçlı Yazılmış Metotdur.
        public void listele(string sqlcumle,DataGridView datagrid)
        {
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açıyoruz          //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            SqlDataAdapter da = new SqlDataAdapter(sqlcumle,baglanti);                    //SqlDataAdapter Sınıfından da Adında Nesne Türettim Ve İçine Komut Nesnesi Gönderdimki Komut Nesnemizi Uyarlasın.
            DataTable dt = new DataTable();                                  //DataTable Sınıfından dt Adında Nesne Türettim.
            da.Fill(dt);                                                    //DataAdapter Nesnesinden Türettiğim Nesneyi Fill Metodu İle İçine dt Nesnesini Göndererek Doldurdum. 
            datagrid.DataSource = dt;                                             //DataGridView Nesnesinin Veri Kaynağını dt Nesnesine Eşitledim.
            baglanti.Close();                                             //Veri Tabanı Bağlantısını Kapattım
        }

        //Formlarda Bulunan Çeşitli İstatistikleri Listelemek Amaçlı Yazılmış Metotdur.
        public void istatistiky(string sqlcumle, Chart Chrt, string seriesic)
        {
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açtım.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);             //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            SqlDataReader dr = komut.ExecuteReader();                         //Birden Fazla Komut Döneceği İçin komut.ExecuteReader diyorum ve datareaderdan oluşturduğum nesneye atıyorum.
            Chrt.Series.Add(seriesic);                                       //Chart Nesnesinin Series Alanına Bir Series Ekliyorum.
            while (dr.Read())                                               //While Döngüsüne dr.read şartını koyarak döngüyü oluşturuyorum
            {       
                Chrt.Series[seriesic].Points.AddY(dr[0]);                 //Chart Nesnesinin Seriesin dışarıdan eklenen seriesic kısmının Point Y Kısmına dr[0] değerini ekliyorum.
            }
            baglanti.Close();                                           //Veri Tabanının Bağlantısını Kapatıyorum.
        }

        //Formlarda Bulunan Çeşitli İstatistikleri Listelemek Amaçlı Yazılmış Metotdur.
        public void istatistikxy(string sqlcumle, Chart Chrt, string seriesic)
        {
            baglanti.Open();                                                    //Veri Tabanı Bağlantısını Açtım.
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);             //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'SQL CÜMLE'sini Ve Veri Tabanı Bağlantısını Ekledim (Bu Metodu Birden Çok Yerde Kullanıyorum O Yüzden 'SQL CÜMLE'sini Dışarıdan String Türünde Aldım).
            Chrt.Series.Add(seriesic);                                        //Chart Nesnesinin Series Alanına Bir Series Ekliyorum.
            SqlDataReader dr = komut.ExecuteReader();                        
            while (dr.Read())                                               //While Döngüsüne dr.read şartını koyarak döngüyü oluşturuyorum
            {
                Chrt.Series[seriesic].Points.AddXY(dr[0], dr[1]);         //Chart Nesnesinin Seriesin dışarıdan eklenen seriesic kısmının Point Y Kısmına dr[0], Point X Kısmına dr[1] değerini ekliyorum.
            }
            baglanti.Close();                                           //Veri Tabanının Bağlantısını Kapatıyorum.

        }

        //Sipariş Formunda Bulunan Siparis tablosundaki herhangi bir kayıta tıklandığı zaman Siparis_Urun_Detay Tablosundaki Gerekli Kolonları Getiren Metotdur.
        public void tasi(TextBox birinci, TextBox ikinci, TextBox ucuncu, TextBox dorduncu, TextBox besinci)
        {
            SqlCommand komut = new SqlCommand("tasima",baglanti);                                     //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'tasima' türünde string ifadeyi yolladım bu sayede 'tasima' StoredProcudure çalışacak Ve Veri Tabanı Bağlantısını Ekledim.
            komut.CommandType = CommandType.StoredProcedure;                                         //Command Nesnesinin Varsayılan Değeri Textdir Bende StoredProcedure Kullanmak İstediğim İçin CommandType ile Tipini Belirtiyorum.
            komut.Parameters.Add("@deger", SqlDbType.Int);                                          //Veritabanında kayıtlı '@deger' değişkenini int türünde olduğu için Add Metodu ile Parametreyi eklerken İnt türünde olduğunu belirterek ekledim.
            komut.Parameters["@deger"].Direction = ParameterDirection.Output;                      //Varsayılan Olarak Direction Özelliği bu parametre için inputtur. Ben bu değişkeni veritabanında output olarak tanımladığım için buradada output olduğunu belirtiyorum
            komut.Parameters.Add("@deger2", SqlDbType.Int);
            komut.Parameters["@deger2"].Direction = ParameterDirection.Output;
            komut.Parameters.Add("@deger4", SqlDbType.Int);
            komut.Parameters["@deger4"].Direction = ParameterDirection.Output;
            komut.Parameters.Add("@deger5", SqlDbType.Int);
            komut.Parameters["@deger5"].Direction = ParameterDirection.Output;
            komut.Parameters.Add("@deger3", SqlDbType.Int);                                     //Veritabanında kayıtlı '@deger' değişkenini int türünde olduğu için Add Metodu ile Parametreyi İnt türünde olduğunu belirterek ekledim.          
            int a = Convert.ToInt32(birinci.Text);                                             //'birinci' adlı textbox nesnesinin text değerini İnt Türüne Çevirerek 'a' Değişkenine atadım.
            komut.Parameters["@deger3"].Value = a;                                            //'a' değişkenine atadığım değeri veritabanında bulunan '@deger3' değişkenine atadım.
            baglanti.Open();
            komut.ExecuteNonQuery();                                                       //'tasima' storedprocedurunu çalıştırdım.
            ikinci.Text = komut.Parameters["@deger"].Value.ToString();                    //'tasima' storedprocedur undeki '@deger' değişkeninin değerini stringe çevirerek ilgili textboxa aktardım.
            ucuncu.Text = komut.Parameters["@deger2"].Value.ToString();                  //'tasima' storedprocedur undeki '@deger2' değişkeninin değerini stringe çevirerek ilgili textboxa aktardım.
            dorduncu.Text = komut.Parameters["@deger4"].Value.ToString();
            besinci.Text = komut.Parameters["@deger5"].Value.ToString();

            baglanti.Close();
        }

        //Sipariş Tablosunda birim fiyat ve adet değerleri girilince gelen değerleri çarpıp toplamfiyat kolonuna yazdıran metot
        public void toplamfiyat(TextBox ikinci, TextBox ucuncu, TextBox dorduncu)
        {
            SqlCommand komut = new SqlCommand("toplamfiyat", baglanti);                               //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine 'toplamfiyat' türünde string ifadeyi yolladım bu sayede 'toplamfiyat' StoredProcudure çalışacak Ve Veri Tabanı Bağlantısını Ekledim.
            komut.CommandType = CommandType.StoredProcedure;                                         //Command Nesnesinin Varsayılan Değeri Textdir Bende StoredProcedure Kullanmak İstediğim İçin CommandType ile Tipini Belirtiyorum.
            komut.Parameters.Add("@tfiyat", SqlDbType.Int);                                          //Veritabanında kayıtlı '@tfiyat' değişkenini int türünde olduğu için Add Metodu ile Parametreyi eklerken İnt türünde olduğunu belirterek ekledim.
            komut.Parameters["@tfiyat"].Direction = ParameterDirection.Output;                      //Varsayılan Olarak Direction Özelliği bu parametre için inputtur. Ben bu değişkeni veritabanında output olarak tanımladığım için buradada output olduğunu belirtiyorum
            komut.Parameters.Add("@bfiyat", SqlDbType.Int);
            komut.Parameters.Add("@adet", SqlDbType.Int);                                       //Veritabanında kayıtlı '@adet' değişkenini int türünde olduğu için Add Metodu ile Parametreyi İnt türünde olduğunu belirterek ekledim.          
            int a = Convert.ToInt32(ikinci.Text);
            int b = Convert.ToInt32(ucuncu.Text);
            komut.Parameters["@bfiyat"].Value = a;
            komut.Parameters["@adet"].Value = b;                                         //'a' değişkenine atadığım değeri veritabanında bulunan '@adet' değişkenine atadım.
            baglanti.Open();
            komut.ExecuteNonQuery();                                                       //'toplamfiyat' storedprocedurunu çalıştırdım.
            dorduncu.Text = komut.Parameters["@tfiyat"].Value.ToString();                    //'toplamfiyat' storedprocedur undeki '@tfiyat' değişkeninin değerini stringe çevirerek ilgili textboxa aktardım.   
            baglanti.Close();
        }

        //Sipariş Formunda S_No Alanını Otomatik Artma Şeklinde Yapmadığım İçin Kendim Otomatik Artmasını Sağladım.
        public void sonproc(SqlCommand komut)
        {
            komut.Connection = baglanti;                                                         //veritabanı bağlantısını alması gerektiği yeri gösterdim.
            komut.CommandText = "son1";                                                         //komut.commandtex e son1 storedprocedure nü atadım
            komut.CommandType = CommandType.StoredProcedure;                                   //Command Nesnesinin Varsayılan Değeri Textdir Bende StoredProcedure Kullanmak İstediğim İçin CommandType ile Tipini Belirtiyorum.
            komut.Parameters.Add("@deger", SqlDbType.Int);                                    //Veritabanında kayıtlı '@deger' değişkenini int türünde olduğu için Add Metodu ile Parametreyi eklerken İnt türünde olduğunu belirterek ekledim.
            komut.Parameters["@deger"].Direction = ParameterDirection.Output;                //Varsayılan Olarak Direction Özelliği bu parametre için inputtur. Ben bu değişkeni veritabanında output olarak tanımladığım için buradada output olduğunu belirtiyorum
            baglanti.Open();
            komut.ExecuteNonQuery();                                                       //'son1' storedprocedurunu çalıştırdım.
            baglanti.Close();
        }

        //Rapor Formunda Ürün Raporlamak için oluşturduğum metot
        public void rapor(string sqlcumle,WindowsFormsApp3.Rapor.urun u , CrystalDecisions.Windows.Forms.CrystalReportViewer crystalreport)
        {
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);                                      //Rapor için kullanacağımız sql cümlesini dışarıdan alıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);                                             //komut nesnemizi uyarlaması için DataAdapter nesnesi oluşturyoruz.
            DataTable dt = new DataTable();                                                           //Sanal bir tablo oluşturuyoruz
            dt.Clear();                                                                              //Metot birden çok kez kullanıldığı için tabloda veri olmaması için temizliyoruz.
            da.Fill(dt);                                                                            //Sanal Tablomuzu Uyarladığımız Veriyle Dolduruyoruz.
            u.SetDataSource(dt);                                                                   //Raporlamada kullandığım ürün sınıfının kaynağını dt olduğunu belirtiyorum.
            crystalreport.ReportSource = u;                                                       //Rapor formunda kullandığım crystalreport aracının rapor kaynağını u nesnesi olduğunu belirtiyorum
        }

        //Rapor Formunda Sipariş Raporlamak için oluşturduğum metot
        public void rapor(string sqlcumle, WindowsFormsApp3.Rapor.siparis s, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalreport)
        {
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);                                      //Rapor için kullanacağımız sql cümlesini dışarıdan alıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);                                             //komut nesnemizi uyarlaması için DataAdapter nesnesi oluşturyoruz.
            DataTable dt = new DataTable();                                                           //Sanal bir tablo oluşturuyoruz
            dt.Clear();                                                                              //Metot birden çok kez kullanıldığı için tabloda veri olmaması için temizliyoruz.
            da.Fill(dt);                                                                            //Sanal Tablomuzu Uyarladığımız Veriyle Dolduruyoruz.
            s.SetDataSource(dt);                                                                   //Raporlamada kullandığım siparis sınıfının kaynağını dt olduğunu belirtiyorum.
            crystalreport.ReportSource = s;                                                       //Rapor formunda kullandığım crystalreport aracının rapor kaynağını s nesnesi olduğunu belirtiyorum
        }

        //Rapor Formunda Müşteri Raporlamak için oluşturduğum metot
        public void rapor(string sqlcumle, WindowsFormsApp3.Rapor.musteri m, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalreport)
        {
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);                                      //Rapor için kullanacağımız sql cümlesini dışarıdan alıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);                                             //komut nesnemizi uyarlaması için DataAdapter nesnesi oluşturyoruz.
            DataTable dt = new DataTable();                                                           //Sanal bir tablo oluşturuyoruz
            dt.Clear();                                                                              //Metot birden çok kez kullanıldığı için tabloda veri olmaması için temizliyoruz.
            da.Fill(dt);                                                                            //Sanal Tablomuzu Uyarladığımız Veriyle Dolduruyoruz.
            m.SetDataSource(dt);                                                                   //Raporlamada kullandığım musteri sınıfının kaynağını dt olduğunu belirtiyorum.
            crystalreport.ReportSource = m;                                                       //Rapor formunda kullandığım crystalreport aracının rapor kaynağını m nesnesi olduğunu belirtiyorum
        }

        //Rapor Formunda Tedarikçi Raporlamak için oluşturduğum metot
        public void rapor(string sqlcumle, WindowsFormsApp3.Rapor.tedarikci t, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalreport)
        {
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);                                      //Rapor için kullanacağımız sql cümlesini dışarıdan alıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);                                             //komut nesnemizi uyarlaması için DataAdapter nesnesi oluşturyoruz.
            DataTable dt = new DataTable();                                                           //Sanal bir tablo oluşturuyoruz
            dt.Clear();                                                                              //Metot birden çok kez kullanıldığı için tabloda veri olmaması için temizliyoruz.
            da.Fill(dt);                                                                            //Sanal Tablomuzu Uyarladığımız Veriyle Dolduruyoruz.
            t.SetDataSource(dt);                                                                   //Raporlamada kullandığım tedarikci sınıfının kaynağını dt olduğunu belirtiyorum.
            crystalreport.ReportSource = t;                                                       //Rapor formunda kullandığım crystalreport aracının rapor kaynağını t nesnesi olduğunu belirtiyorum
        }

        //Rapor Formunda Kategori Raporlamak için oluşturduğum metot
        public void rapor(string sqlcumle, WindowsFormsApp3.Rapor.kategori k, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalreport)
        {
            SqlCommand komut = new SqlCommand(sqlcumle, baglanti);                                      //Rapor için kullanacağımız sql cümlesini dışarıdan alıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);                                             //komut nesnemizi uyarlaması için DataAdapter nesnesi oluşturyoruz.
            DataTable dt = new DataTable();                                                           //Sanal bir tablo oluşturuyoruz
            dt.Clear();                                                                              //Metot birden çok kez kullanıldığı için tabloda veri olmaması için temizliyoruz.
            da.Fill(dt);                                                                            //Sanal Tablomuzu Uyarladığımız Veriyle Dolduruyoruz.
            k.SetDataSource(dt);                                                                   //Raporlamada kullandığım kategori sınıfının kaynağını dt olduğunu belirtiyorum.
            crystalreport.ReportSource = k;                                                       //Rapor formunda kullandığım crystalreport aracının rapor kaynağını k nesnesi olduğunu belirtiyorum
        }

        //primary key kontrolü için yazılmış bir metot
        public void prkeykontrol(string procedure_ismi ,TextBox deger)
        {
            SqlCommand komut = new SqlCommand(procedure_ismi, baglanti);                                     //SqlCommand Sınıfından Komut Adında Nesne Türettim Ve İçine parametre olarak aldığım string ifadeyi yolladım bu sayede StoredProcudure çalışacak Ve Veri Tabanı Bağlantısını Ekledim.
            komut.CommandType = CommandType.StoredProcedure;                                                //Command Nesnesinin Varsayılan Değeri Textdir Bende StoredProcedure Kullanmak İstediğim İçin CommandType ile Tipini Belirtiyorum.
            komut.Parameters.Add("@kontrol", SqlDbType.Int);                                               //Veritabanında kayıtlı '@kontrol' değişkenini int türünde olduğu için Add Metodu ile Parametreyi eklerken İnt türünde olduğunu belirterek ekledim.
            komut.Parameters["@kontrol"].Direction = ParameterDirection.Output;                           //Varsayılan Olarak Direction Özelliği bu parametre için inputtur. Ben bu değişkeni veritabanında output olarak tanımladığım için buradada output olduğunu belirtiyorum
            komut.Parameters.Add("@deger", SqlDbType.Int);
            int a = Convert.ToInt32(deger.Text);
            komut.Parameters["@deger"].Value = a;
            baglanti.Open();
            komut.ExecuteNonQuery();                                                                //storedprocedurunu çalıştırdım.
            y = komut.Parameters["@kontrol"].Value.ToString();                                     //'storedprocedur deki '@kontrol' değişkeninin değerini stringe çevirerek ilgili textboxa aktardım.
            baglanti.Close();
        }
    }
}
