using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class GyvSkaicPrid_SaugPuol : Veikejas
    {
        private GyvybiuSkaiciavimasPridetinis GyvybiuTipas;
        private SaugusPuolimas PuolimoTipas;

        public GyvSkaicPrid_SaugPuol(int kilme, int klase, int lygis, int sarvai, int maxZala)
        {
            this.GyvybiuTipas = new GyvybiuSkaiciavimasPridetinis();
            this.PuolimoTipas = new SaugusPuolimas();
            this.KeistiLygi(lygis);
            this.sarvai = sarvai;
            this.maxZala = maxZala;
            switch (klase)
            {
                case (int)Klase.Karvedys:
                    this.klase = "Karvedys";
                    break;
                case (int)Klase.Kovotojas:
                    this.klase = "Kovotojas";
                    break;
                case (int)Klase.Magas:
                    this.klase = "Magas";
                    break;
                case (int)Klase.Alchemikas:
                    this.klase = "Alchemikas";
                    break;
                default:
                    this.klase = "Kovotojas";
                    break;
            }
            switch (kilme)
            {
                case (int)Klase.Karvedys:
                    this.kilme = "Troja";
                    break;
                case (int)Klase.Kovotojas:
                    this.kilme = "Maneja";
                    break;
                case (int)Klase.Magas:
                    this.kilme = "Trofis";
                    break;
                default:
                    this.kilme = "Trofis";
                    break;
            }
            this.gyvas = true;
        }
        public GyvSkaicPrid_SaugPuol(int kilme, int klase)
        {
            this.GyvybiuTipas = new GyvybiuSkaiciavimasPridetinis();
            this.PuolimoTipas = new SaugusPuolimas();
            this.KeistiLygi(5);
            this.sarvai = lygis * 10;
            this.maxZala = 5;
            switch (klase)
            {
                case (int)Klase.Karvedys:
                    this.klase = "Karvedys";
                    break;
                case (int)Klase.Kovotojas:
                    this.klase = "Kovotojas";
                    break;
                case (int)Klase.Magas:
                    this.klase = "Magas";
                    break;
                case (int)Klase.Alchemikas:
                    this.klase = "Alchemikas";
                    break;
                default:
                    this.klase = "Kovotojas";
                    break;
            }
            switch (kilme)
            {
                case (int)Klase.Karvedys:
                    this.kilme = "Troja";
                    break;
                case (int)Klase.Kovotojas:
                    this.kilme = "Maneja";
                    break;
                case (int)Klase.Magas:
                    this.kilme = "Trofis";
                    break;
                default:
                    this.kilme = "Trofis";
                    break;
            }
            this.gyvas = true;
        }
        protected override double GyvybiuSkaiciavimas()
        {
            double apskGyv;
            apskGyv = this.GyvybiuTipas.veikejoGyvybes(this.gyvybes, this.sarvai, this.lygis);
            apskGyv = this.GyvybiuTipas.papildomosGyvybes(this.klase, apskGyv, this.kilme);
            return apskGyv;
        }

        protected override void AtnaujintiZala()
        {
            this.maxZala = this.PuolimoTipas.zalosKeitimas(this.lygis, this.klase);
        }
    }
}
