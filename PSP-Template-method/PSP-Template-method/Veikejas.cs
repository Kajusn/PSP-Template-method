using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    public abstract class Veikejas
    {
        protected enum Klase { Karvedys = 1, Kovotojas, Magas, Alchemikas };
        protected enum Kilme { Troja = 1, Maneja, Trofis };
        protected enum PuolimoTipai { Agresyvus = 1, Saugus };
        public double sarvai { get; set; }
        public int lygis;
        public bool gyvas;
        public double gyvybes;
        public double maxZala;
        public string kilme;
        public string klase;
        public string strategija;

        public double Gyvybes()
        {
            return GyvybiuSkaiciavimas();
        }
        protected void KeistiLygi(int naujasLygis)
        {
            this.lygis = naujasLygis;
            this.gyvybes = this.lygis * 100;
            this.gyvybes = Gyvybes();
            AtnaujintiZala();
        }
        protected abstract double GyvybiuSkaiciavimas();

        protected abstract void AtnaujintiZala();
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
