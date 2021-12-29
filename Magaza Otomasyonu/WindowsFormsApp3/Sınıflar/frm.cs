using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace melihkocak0385
{
    class frm
    {
        public int[] dizi = new int[3];  // formların formborderstyle özelliği none olunca hareket ettirmek için değişken tanımlamak gerekiyordu bu da o değişkenler dizi halinde tutuyorum

        //frm_ana formunda mdi form kullanıyorum formu panel içinde getirmek için yazıldı bu metot
        public void formgetir(Form getirilecekform, Panel gösterilecekpanel, Form kontrol)
        {
            
            frm_ana c = new frm_ana();                                                                  //frm_ana formunda c adında bir nesne türettim
            if (Application.OpenForms["kontrol"] == null || kontrol.IsDisposed)                        //Herhangi bir formun açık olup olmadığını kontrol ediyorum.
            {
                gösterilecekpanel.Controls.Clear();                                                  //Her ihtimale karşı panelin içini temizliyorum.
                getirilecekform.MdiParent = c;                                                      //Gösterilecek olan formun mdiparent özelliğine c nesnesini atıyorum.
                gösterilecekpanel.Controls.Add(getirilecekform);                                   //Getirilecek olan formu gösterilecek olan panele ekliyorum.
                getirilecekform.Show();                                                           //Getirilecek olan formu gösteriyorum.
            }
            else                                                                                //Aksi halde ise hata mesajı vermesini istedtim
            {
                MessageBox.Show("Aktif Pencereyi Kapatmadan Başka Bir Pencere Veya Aynı Pencere Açılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        //Textboxlar için contextmenüstrip oluşturmuştüm öğelerinden birisi yapıştır idi onun için metot yazdım
        public void yapistir(Form kontrol)
        {
            try                                                                                 //Yapıştırılacak herhangi bir öğe olmadığında hata veriyordu o yüzden try catch bloklarının içine yazdım.
            {
                Control ctrl = kontrol.ActiveControl;                                         //Control sınıfından nesne türetip nesnenin içine sınıfın aktifliği kontrol edilip döndürülen değer yazılmıştır
                TextBox tx = (TextBox)ctrl;                                                  //Textbox sınıfından nesne türettim onun içine textboxa çevirerek ctrl nesnesini attım.
                if (ctrl != null)
                    if (ctrl is TextBox)                                                   //ctrl nesnesi is cümleciği ile textbox nesnesi olup olmadığı kontrol ediliyor
                        tx.Paste();                                                       //Panodaki veriler textboxa yapıştırılıyor.
            }
            catch (Exception)
            {
            }
        }

        //Textboxlar için contextmenüstrip oluşturmuştüm öğelerinden birisi kopyala idi onun için metot yazdım
        public void kopyala(Form kontrol)
        {
            try                                                                                 //Kopyalanacak herhangi bir öğe olmadığında hata veriyordu o yüzden try catch bloklarının içine yazdım.
            {
                Control ctrl = kontrol.ActiveControl;                                         //Control sınıfından nesne türetip nesnenin içine sınıfın aktifliği kontrol edilip döndürülen değer yazılmıştır
                TextBox tx = (TextBox)ctrl;                                                  //Textbox sınıfından nesne türettim onun içine textboxa çevirerek ctrl nesnesini attım.
                if (ctrl != null)                       
                    if (ctrl is TextBox)                                                   //ctrl nesnesi is cümleciği ile textbox nesnesi olup olmadığı kontrol ediliyor
                        tx.Copy();                                                        //Textboxtaki veriler panoya kopyalanıyor.
            }
            catch (Exception)
            {
            }
        }

        //Textboxlar için contextmenüstrip oluşturmuştüm öğelerinden birisi kes idi onun için metot yazdım
        public void kes(Form kontrol)
        {
            try                                                                                 //Kesilecek herhangi bir öğe olmadığında hata veriyordu o yüzden try catch bloklarının içine yazdım.
            {
                Control ctrl = kontrol.ActiveControl;                                         //Control sınıfından nesne türetip nesnenin içine sınıfın aktifliği kontrol edilip döndürülen değer yazılmıştır
                TextBox tx = (TextBox)ctrl;                                                  //Textbox sınıfından nesne türettim onun içine textboxa çevirerek ctrl nesnesini attım.
                if (ctrl != null)
                    if (ctrl is TextBox)                                                   //ctrl nesnesi is cümleciği ile textbox nesnesi olup olmadığı kontrol ediliyor
                        tx.Cut();                                                         //Textboxtaki veriler panoya Kesme sureti ile alınıyor.
            }
            catch (Exception)
            {
            }
        }

        //Textboxlar için contextmenüstrip oluşturmuştüm öğelerinden birisi Tümünü Seç idi onun için metot yazdım
        public void tumunusec(Form kontrol)
        {
            try                                                                                 //Tümünü Seçecek herhangi bir öğe olmadığında hata veriyordu o yüzden try catch bloklarının içine yazdım.
            {
                Control ctrl = kontrol.ActiveControl;                                         //Control sınıfından nesne türetip nesnenin içine sınıfın aktifliği kontrol edilip döndürülen değer yazılmıştır
                TextBox tx = (TextBox)ctrl;                                                  //Textbox sınıfından nesne türettim onun içine textboxa çevirerek ctrl nesnesini attım.
                if (ctrl != null)
                    if (ctrl is TextBox)                                                   //ctrl nesnesi is cümleciği ile textbox nesnesi olup olmadığı kontrol ediliyor
                        tx.SelectAll();                                                   //Textboxdaki veriler tümünü seç ile seçiliyor
            }
            catch (Exception)
            {
            }
        }

        //Textboxların üstündeki küçük buton sıfırlama butonudur. Metodun içine yollanan textboxları sıfırlıyor.
        public void sifirla(TextBox birinci, TextBox ikinci, TextBox ucuncu, TextBox dorduncu)
        {
            birinci.Text = "";
            ikinci.Text = "";
            ucuncu.Text = "";
            dorduncu.Text = "";
        }

        //Textboxların üstündeki küçük buton sıfırlama butonudur. Metodun içine yollanan textboxları sıfırlıyor.
        public void sifirla(TextBox birinci, TextBox ikinci, TextBox ucuncu, TextBox dorduncu, TextBox besinci, TextBox altinci)
        {
            birinci.Text = "";
            ikinci.Text = "";
            ucuncu.Text = "";
            dorduncu.Text = "";
            besinci.Text = "";
            altinci.Text = "";
        }

        //Textboxların üstündeki küçük buton sıfırlama butonudur. Metodun içine yollanan textboxları sıfırlıyor.
        public void sifirla(TextBox birinci, TextBox ikinci, TextBox ucuncu, TextBox dorduncu, TextBox besinci)
        {
            birinci.Text = "";
            ikinci.Text = "";
            ucuncu.Text = "";
            dorduncu.Text = "";
            besinci.Text = "";
            birinci.Enabled = true;
        }

        //Textboxların üstündeki küçük buton sıfırlama butonudur. Metodun içine yollanan textboxları sıfırlıyor.
        public void sifirla(TextBox birinci, TextBox ikinci)
        {
            birinci.Text = "";
            ikinci.Text = "";
        }

    }
}
