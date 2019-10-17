using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class PastatasPaprastosGyvybes : Pastatas
    {
        private GyvybiuSkaiciavimasPaprastas gsp = new GyvybiuSkaiciavimasPaprastas();
        protected override double Gyvybes()
        {
            return gsp.veikejoGyvybes(100, apsaugos, aukstis);
        }
    }
}
