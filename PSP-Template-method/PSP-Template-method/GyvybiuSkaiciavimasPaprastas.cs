using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    public class GyvybiuSkaiciavimasPaprastas
    {
        public double papildomosGyvybes(string klase, double gyvybes, string kilme)
        {
            return gyvybes;
        }

        public double veikejoGyvybes(double gyvybes, double sarvai, int lygis)
        {
            return gyvybes * lygis;
        }
    }
}
