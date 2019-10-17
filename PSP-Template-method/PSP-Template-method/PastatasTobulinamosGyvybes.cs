using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    class PastatasTobulinamosGyvybes : Pastatas
    {
        private GyvybiuSkaiciavimasTobulinamas gsp = new GyvybiuSkaiciavimasTobulinamas();
        protected override double Gyvybes()
        {
            return gsp.veikejoGyvybes(100, apsaugos, aukstis);
        }
    }
}
