using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    public abstract class Veikejas
    {
        private enum Klase { Karvedys = 1, Kovotojas, Magas, Alchemikas };
        private enum Kilme { Troja = 1, Maneja, Trofis };
        private enum PuolimoTipai { Agresyvus = 1, Saugus };
        public double sarvai { get; set; }
        public int lygis;
        public bool gyvas;
        public double gyvybes;
        public double maxZala;
        public string kilme;
        public string klase;
        public string strategija;

        public abstract void KeistiLygi(int naujasLygis);
        public abstract double GyvybiuSkaiciavimas();
        public abstract void PasirinktiPuolimoTipa(int tipas);
        public bool Pulti(Veikejas taikinys)
        {
            if (!taikinys.gyvas) return false;
            if (taikinys.sarvai > 0)
            {
                if (this.maxZala >= taikinys.sarvai)
                {
                    taikinys.sarvai = 0;
                    return true;
                }
                else taikinys.sarvai -= this.maxZala;
                return true;
            }
            else if (taikinys.gyvybes > this.maxZala)
            {
                taikinys.gyvybes -= this.maxZala;
                return true;
            }
            else if (taikinys.gyvybes <= this.maxZala)
            {
                taikinys.gyvybes = 0;
                taikinys.gyvas = false;
                return true;
            }
            return false;
        }
    }
}
