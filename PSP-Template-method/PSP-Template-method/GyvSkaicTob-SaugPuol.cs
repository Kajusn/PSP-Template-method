using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class GyvSkaicTob_SaugPuol : Veikejas
    {
        private GyvybiuSkaiciavimasTobulinamas GyvybiuTipas = new GyvybiuSkaiciavimasTobulinamas();
        private SaugusPuolimas PuolimoTipas = new SaugusPuolimas();

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
