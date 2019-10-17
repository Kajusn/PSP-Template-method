using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class GyvSkaicTob_AgrPuol : Veikejas
    {
        private GyvybiuSkaiciavimasTobulinamas GyvybiuTipas = new GyvybiuSkaiciavimasTobulinamas();
        private AgresyvusPuolimas PuolimoTipas = new AgresyvusPuolimas();

        protected override double GyvybiuSkaiciavimas()
        {
            return this.GyvybiuTipas.veikejoGyvybes(this.gyvybes, this.sarvai, this.lygis);
        }

        protected override void KeistiLygi(int naujasLygis)
        {
            this.lygis = naujasLygis;
            this.gyvybes = this.lygis * 100;
            this.gyvybes = GyvybiuSkaiciavimas();
            if (this.PuolimoTipas != null)
                this.maxZala = this.PuolimoTipas.zalosKeitimas(this.lygis, this.klase);
        }
    }
}
