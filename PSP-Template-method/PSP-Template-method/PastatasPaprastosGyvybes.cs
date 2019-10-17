﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class PastatasPaprastosGyvybes : Pastatas
    {
        private GyvybiuSkaiciavimasPaprastas gsp;

        public PastatasPaprastosGyvybes(int aukstis, double apsaugos, string regionas, string tipas)
        {
            this.aukstis = aukstis;
            this.apsaugos = apsaugos;
            this.regionas = regionas;
            this.tipas = tipas;
            this.gsp = new GyvybiuSkaiciavimasPaprastas();
            this.gyvybes = Gyvybes();
        }

        protected override double papildomosGyvybes()
        {
            return gsp.papildomosGyvybes(tipas, aukstis, regionas);
        }

        protected override double veikejoGyvybes()
        {
            return gsp.veikejoGyvybes(100, apsaugos, aukstis);
        }
    }
}
