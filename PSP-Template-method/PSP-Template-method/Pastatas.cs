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

        protected abstract double Gyvybes();
        public double PastatoGyvybes()
        {
            return Gyvybes();
        }
    }
}
