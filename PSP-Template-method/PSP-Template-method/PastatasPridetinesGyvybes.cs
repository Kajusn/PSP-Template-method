using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class PastatasPridetinesGyvybes : Pastatas
    {
        private GyvybiuSkaiciavimasPridetinis gsp = new GyvybiuSkaiciavimasPridetinis();
        protected override double Gyvybes()
        {
            return gsp.veikejoGyvybes(100, apsaugos, aukstis);
        }
    }
}
