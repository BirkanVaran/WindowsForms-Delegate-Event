using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFormDelegateVeEvent
{
    public class SayiKontrol
    {
        public delegate void SayiKontrolEtHandler();
        public event SayiKontrolEtHandler SayiDurumu;
        public string SayiDurumMeasji { get; set; } = "Lütfen 0 veya pozitif sayı giriniz.";

        private int _sayi;
        public int Sayi        {
            get
            {
                return _sayi;
            }
            set
            {
                _sayi = value;
                if (_sayi<10)
                {
                   
                    //Olay(event) çalışsın
                    // Event'e SayıKonrolEtHandler Delegate'inin temsil ettiği metodu çalıştırır.
                    if (SayiDurumu!=null)
                    {
                        SayiKontroluGectiMi = false;
                        SayiDurumu();
                    }
                }
                else
                {
                    SayiKontroluGectiMi = true;
                }
            }
        }

        public bool SayiKontroluGectiMi { get; set; }
    }
}
