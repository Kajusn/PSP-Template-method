using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class GyvSkaicPapr_SaugPuol : Veikejas
    {
        private GyvybiuSkaiciavimasPaprastas GyvybiuTipas = new GyvybiuSkaiciavimasPaprastas();
        private SaugusPuolimas PuolimoTipas = new SaugusPuolimas();

        protected override void AtnaujintiZala()
        {
            this.maxZala = this.PuolimoTipas.zalosKeitimas(this.lygis, this.klase);
        }

        protected override double GyvybiuSkaiciavimas()
        {
            return this.GyvybiuTipas.veikejoGyvybes(this.gyvybes, this.sarvai, this.lygis);
        }
    }
}
