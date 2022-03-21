using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormDelegateVeEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // GLOBAL ALAN
        SayiKontrol sayiKontroluNesnesi = new SayiKontrol();
        public void MerhabaDiyeSelamVer()
        {
            MessageBox.Show("Merhaba!");
        }
        // Bir delege tanımladık.
        // Void ve parametre almayan metotları temsil edebilir.
        public delegate void CalismaHandler();

        public delegate int IslemYapHandler(int s1, int s2);

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Bir metodu ismiyle çağıralım:
            // MerhabaDiyeSelamVer();

            //CalismaHandler benim_CalismaHandlerim = new CalismaHandler(MerhabaDiyeSelamVer);

            //// 1: yolDelege türünde bir nesne türetip (line 25) Metodu Delegate ile çağıralım:
            //benim_CalismaHandlerim();

            //// 2. Yol: Delegate nesnesinin INVOKE metodunu çağırmak:
            //benim_CalismaHandlerim.Invoke();

            //// 3. Yol: Delegate nesnesinin BEGININVOKE metoduna çalışmasını istediğiniz metodun ismini parametre olarak vermek:
            //this.BeginInvoke(benim_CalismaHandlerim);

            //button2.Click += new EventHandler(button2_Click);
            //button2.MouseMove += new MouseEventHandler(button2_FareUzerineGeldi);


            // Eventlerin tipi Delegate'lerdir.
            /* += ile bir evenet oluşturmak istediğinizde event tanımlarken tip olarak hangi delege verildiyse kendine o delege geliyor.
             * Delegenin imzası yani geri dönüş tipi parametreleri ne ise event'e atanacak metodun imzasının da aynı olması gerekir
             * Örn PaintEventHandler içine object tipte bir sender ve PaintEventArgs tipinde e isimli parametreler almış.
             * Bu nedenle button2_Paint isimli metot da aynı imzaya yani aynı geri dönüş tipi ve aynı parametrelere sahip olmalıdır
             * Böylece o delege kendisine constructor'da atanan metodu temsil edebiliyor. */

            //button2.Paint += new PaintEventHandler(button2_Paint);
            sayiKontroluNesnesi.SayiDurumu += new SayiKontrol.SayiKontrolEtHandler(Kontrol);

        }

        //private void button2_Paint(object sender, PaintEventArgs e)
        //{
        //    MessageBox.Show("Buton2'nin PaintEvent'i çalışıyor.");
        //}

        //private void button2_FareUzerineGeldi(object sender, EventArgs e)
        //{
        //    button2.BackColor = Color.DarkGreen;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 2'ye tıkladınız.");
        }

        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            try
            {
                IslemYapHandler benimIslemDelegem = new IslemYapHandler(Topla);
                //+= ile Carp metodunu verince bu delegenin sonucunda iki sayı çarpılır.
                //Bu messageBox iki sayıyı toplayıp işlem yapar
                MessageBox.Show("Sonucumuz: " + benimIslemDelegem(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)));
                // burada carp metodu delegeye atandığı için çarpma işlemi yapılır
                benimIslemDelegem += Carp;

                MessageBox.Show("Sonucumuz: " + benimIslemDelegem(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)));

                //-= ile Carp metodunu delege temsilinden çıkarırsak bir önceki temsil ettiği metodun işlemini yapıp iki sayıyı toplayacaktır
                benimIslemDelegem -= Carp;
                // Carp metodu temsilden çıkarıldığı için toplama işlemi yapar
                MessageBox.Show("Sonucumuz: " + benimIslemDelegem(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)));

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            IslemYapHandler benimIslemDelegem = new IslemYapHandler(Topla);
            benimIslemDelegem += Carp;

            Delegate[] delegateMetotlari = benimIslemDelegem.GetInvocationList();
            foreach (Delegate item in delegateMetotlari)
            {
                string metotParametreBilgileri = string.Empty;
                ParameterInfo[] itemParameters = item.Method.GetParameters();
                foreach (var theParameter in itemParameters)
                {
                    metotParametreBilgileri += $"Parametre Adı: {theParameter.Name}\n" +
                                             $"Parametrenin Tipi: {theParameter.ParameterType.Name}\n";
                }
                MessageBox.Show($"Çalışan metodun adı: {item.Method.Name}\n" +
                    $"Çalışan metodun geriye dönüş tipi: {item.Method.ReturnType}\n" +
                    $"Çalışan metodun parametre bilgileri" +
                    $"\n{metotParametreBilgileri}\n" +
                    $"Sonuç: {item.DynamicInvoke(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text))}");
            }

        }
        public void Kontrol()
        {
            MessageBox.Show(sayiKontroluNesnesi.SayiDurumMeasji);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SayiKontrol sayiKontrolNesnem = new SayiKontrol();
            sayiKontrolNesnem.SayiDurumu += new SayiKontrol.SayiKontrolEtHandler(Kontrol);
            sayiKontrolNesnem.Sayi = Convert.ToInt32(txtSayi1.Text);

        }

        private void btnSonucPozitif_Click(object sender, EventArgs e)
        {
            sayiKontroluNesnesi.Sayi = Convert.ToInt32(txtSayi1.Text);
            if (sayiKontroluNesnesi.SayiKontroluGectiMi == false)
            {
                return;
            }
            sayiKontroluNesnesi.Sayi = Convert.ToInt32(txtSayi2.Text);
            if (sayiKontroluNesnesi.SayiKontroluGectiMi == false)
            {
                return;
            }
            IslemYapHandler islemim = new IslemYapHandler(Topla);
            MessageBox.Show("Toplama sonucu: " + islemim.Invoke(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text)));

        }
    }
}
