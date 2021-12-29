using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melihkocak0385
{
    
    public partial class frm_ana : Form
    {
        db k = new db();
        frm f = new frm();

        public void frm_ana_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;      //frm_ana formunun formborderstyle özelliği none olduğu için hareket etmiyordu bu kod diğer bazı kodlar hareket ettirmek için yazıldı.
        }                                                                
        public frm_ana()
        {
            InitializeComponent();
        }

        //
        //  Müşteri Butonu
        //

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            frm_musteri a = new frm_musteri();  //Müşteri formundan nesne türettim
            a.Name = "kontrol";//aktif bir form varken başka bir form açılmasını engellemek için name kısmınına "kontrol" adını verdim.
            f.formgetir(a, pnl_orta,a);//frm classında bulunan bu metot 'pnl_orta' paneline daha önceden açık bir form varmı yokmu kontrolünü yaparak içine gönderdiğimiz form nesnesini getiriyor. eğer daha önceden açık bir form varsa hata mesajı veriyor.
            pnl_gecis.Top = btn_musteri.Top;//Butona tıklayınca yandaki panelin geçişini sağlayan yok
        }
        
        //
        //  Ürün Butonu
        //

        private void btn_urun_Click(object sender, EventArgs e)
        {
            frm_urun a = new frm_urun();//Ürün formundan nesne türettim
            a.Name = "kontrol";//başka bir form açılmasını engellemek için name kısmınına "kontrol" adını verdim.
            f.formgetir(a, pnl_orta,a);//frm classında bulunan bu metot 'pnl_orta' paneline daha önceden açık bir form varmı kontrolünü yaparak içine gönderdiğimiz form nesnesini getiriyor. eğer daha önceden açık bir form varsa hata mesajı veriyor.
            pnl_gecis.Top = btn_urun.Top;//Butona tıklayınca yandaki panelin geçişini sağlayan yok
        }

        //
        //  Kategori Butonu
        //

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            frm_kategori a = new frm_kategori();//Kategori formundan nesne türettim
            a.Name = "kontrol";//başka bir form açılmasını engellemek için name kısmınına "kontrol" adını verdim.
            f.formgetir(a, pnl_orta,a);//frm classında bulunan bu metot 'pnl_orta' paneline daha önceden açık bir form varmı kontrolünü yaparak içine gönderdiğimiz form nesnesini getiriyor. eğer daha önceden açık bir form varsa hata mesajı veriyor.
            pnl_gecis.Top = btn_kategori.Top;//Butona tıklayınca yandaki panelin geçişini sağlayan yok
        }

        //
        // Sipariş Butonu
        //

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            frm_siparis a = new frm_siparis();//Sipariş formundan nesne türettim
            a.Name = "kontrol";//başka bir form açılmasını engellemek için name kısmınına "kontrol" adını verdim.
            f.formgetir(a, pnl_orta, a);//frm classında bulunan bu metot 'pnl_orta' paneline daha önceden açık bir form varmı kontrolünü yaparak içine gönderdiğimiz form nesnesini getiriyor. eğer daha önceden açık bir form varsa hata mesajı veriyor.
            pnl_gecis.Top = btn_siparis.Top;//Butona tıklayınca yandaki panelin geçişini sağlayan yok
        }

        //
        //  Çıkış Butonu
        //

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // Tedarikçi Butonu
        //

        private void btn_tedarikciler_Click(object sender, EventArgs e)
        {
            frm_tedarikciler a = new frm_tedarikciler();//Tedairkçiler formundan nesne türettim
            a.Name = "kontrol";//başka bir form açılmasını engellemek için name kısmınına "kontrol" adını verdim.
            f.formgetir(a, pnl_orta, a);//frm classında bulunan bu metot 'pnl_orta' paneline daha önceden açık bir form varmı kontrolünü yaparak içine gönderdiğimiz form nesnesini getiriyor. eğer daha önceden açık bir form varsa hata mesajı veriyor.
            pnl_gecis.Top = btn_tedarikciler.Top;//Butona tıklayınca yandaki panelin geçişini sağlayan yok
        }
        
        //
        //Rapor Butonu
        //

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.Formlar.frm_rapor a = new WindowsFormsApp3.Formlar.frm_rapor();//Rapor formundan nesne türettim
            a.Name = "kontrol";//başka bir form açılmasını engellemek için name kısmınına "kontrol" adını verdim.
            f.formgetir(a, pnl_orta, a);//frm classında bulunan bu metot 'pnl_orta' paneline daha önceden açık bir form varmı kontrolünü yaparak içine gönderdiğimiz form nesnesini getiriyor. eğer daha önceden açık bir form varsa hata mesajı veriyor.
            pnl_gecis.Top = btn_rapor.Top;//Butona tıklayınca yandaki panelin geçişini sağlayan yok
        }

        //
        //formborderstyle none olunca hareket etmesi için
        //
 //-----------------------------------------------------------------------------
        private void pnl_ust_MouseDown(object sender, MouseEventArgs e)
        {
            f.dizi[0] = 1;      
            f.dizi[1] = e.X;            //formborderstyle none olunca hareket etmesi için
            f.dizi[2] = e.Y;
        }

        private void pnl_ust_MouseMove(object sender, MouseEventArgs e)
        {
            if (f.dizi[0]==1)
            {
                this.SetDesktopLocation(MousePosition.X - f.dizi[1], MousePosition.Y - f.dizi[2]);         //formborderstyle none olunca hareket etmesi için
            }
        }

        private void pnl_ust_MouseUp(object sender, MouseEventArgs e)
        {
            f.dizi[0] = 0;              //formborderstyle none olunca hareket etmesi için
        }
//------------------------------------------------------------------------------

       
        //
        // Butonların Altında Panelin Renk Ve Boyutunu Ayarlayan Kodlar
        //
//-------------------------------------------------------------------------------
        private void btn_musteri_MouseHover(object sender, EventArgs e)//Müşteri butonunun mouse ile üzerine gelince gerçekleşecek event 
        {
            pnl_musteri.Size = new Size(180, 3);//Boyutunu ayarlıyorum, küçültüyorum.
            pnl_musteri.BackColor = Color.Brown;//Rengini kahverengi yapıyorum.
            pnl_musteri.Location= new Point(14, 179);//Küçük olunca düzgün durması için yerini değiştirdim.
        }

        private void btn_musteri_MouseLeave(object sender, EventArgs e)//Müşteri butonunun mouse ile üzerine gelip ayrıldıktan sonra gerçekleşecek event
        {
            pnl_musteri.Size = new Size(200, 3);//Boyutunu ayarlıyorum. Eski hale getiriyorum
            pnl_musteri.Location = new Point(5, 179);//Boyut büyüyünce yerinide ilk haline getiriyorum.
            pnl_musteri.BackColor = Color.White;//Tekrardan rengini beyaz yapıyorum.
        }

        private void btn_urun_MouseHover(object sender, EventArgs e)
        {
            pnl_urun.Size = new Size(180, 3);
            pnl_urun.BackColor = Color.Brown;
            pnl_urun.Location = new Point(15, 321);
        }

        private void btn_urun_MouseLeave(object sender, EventArgs e)
        {
            pnl_urun.Size = new Size(200, 3);
            pnl_urun.BackColor = Color.White;
            pnl_urun.Location = new Point(6, 321);
        }

        private void btn_siparis_MouseHover(object sender, EventArgs e)
        {
            pnl_siparis.Size = new Size(180, 3);
            pnl_siparis.BackColor = Color.Brown;
            pnl_siparis.Location = new Point(14, 252);
        }

        private void btn_siparis_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_siparis.Size = new Size(200, 2);
            pnl_siparis.BackColor = Color.White;
            pnl_siparis.Location = new Point(6, 252);
        }

        private void btn_kategori_MouseHover(object sender, EventArgs e)
        {
            pnl_kategori.Size = new Size(180, 3);
            pnl_kategori.BackColor = Color.Brown;
            pnl_kategori.Location = new Point(14, 459);
        }

        private void btn_kategori_MouseLeave(object sender, EventArgs e)
        {
            pnl_kategori.Size = new Size(200, 3);
            pnl_kategori.BackColor = Color.White;
            pnl_kategori.Location = new Point(6, 459);
        }

        private void btn_tedarikciler_MouseHover(object sender, EventArgs e)
        {
            pnl_tedarikciler.Size = new Size(180, 3);
            pnl_tedarikciler.BackColor = Color.Brown;
            pnl_tedarikciler.Location = new Point(14, 390);
        }

        private void btn_tedarikciler_MouseLeave(object sender, EventArgs e)
        {
            pnl_tedarikciler.Size = new Size(200, 3);
            pnl_tedarikciler.BackColor = Color.White;
            pnl_tedarikciler.Location = new Point(6, 390);
        }

        private void btn_rapor_MouseHover(object sender, EventArgs e)
        {
            pnl_rapor.Size = new Size(180, 3);
            pnl_rapor.BackColor = Color.Brown;
            pnl_rapor.Location = new Point(14, 528);
        }

        private void btn_rapor_MouseLeave(object sender, EventArgs e)
        {
            pnl_rapor.Size = new Size(200, 3);
            pnl_rapor.BackColor = Color.White;
            pnl_rapor.Location = new Point(4, 528);
        }
        //------------------------------------------------------------------------------------
    }
}
