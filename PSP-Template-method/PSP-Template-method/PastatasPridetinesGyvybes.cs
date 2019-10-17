using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class PastatasPridetinesGyvybes : Pastatas
    {
        private GyvybiuSkaiciavimasPridetinis gsp;

        public PastatasPridetinesGyvybes(int aukstis, double apsaugos, string regionas, string tipas)
        {
            this.aukstis = aukstis;
            this.apsaugos = apsaugos;
            this.regionas = regionas;
            this.tipas = tipas;
            this.gsp = new GyvybiuSkaiciavimasPridetinis();
            this.gyvybes = PastatoGyvybes();
        }
        protected override double Gyvybes()
        {
            return gsp.veikejoGyvybes(100, apsaugos, aukstis);
        }
    }
}
