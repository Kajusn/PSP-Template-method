using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    public abstract class Pastatas
    {
        public bool stovi;
        public int aukstis;
        public double gyvybes;
        public double apsaugos;
        public string regionas;
        public string tipas;

        public double Gyvybes()
        {
            double apskGyvybes = veikejoGyvybes();
            apskGyvybes = papildomosGyvybes();
            return apskGyvybes;
        }
        protected abstract double veikejoGyvybes();
        protected abstract double papildomosGyvybes();
    }
}
