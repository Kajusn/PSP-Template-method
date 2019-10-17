﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_Template_method
{
    public class GyvybiuSkaiciavimasPridetinis
    {
        private double perskaiciuotosGyvybes;
        public double papildomosGyvybes(string klase, double gyvybes, string kilme)
        {
            perskaiciuotosGyvybes = gyvybes;
            switch (klase)
            {
                case "Magas":
                    return perskaiciuotosGyvybes = gyvybes * 0.9;
                case "Kovotojas":
                    return perskaiciuotosGyvybes = gyvybes * 1.5;
                case "Karvedys":
                    {
                        if (kilme == "Troja")
                            return perskaiciuotosGyvybes = gyvybes * 1.5;
                        else
                            return perskaiciuotosGyvybes;
                    }
                case "Alchemikas":
                    return perskaiciuotosGyvybes = gyvybes * 1.05;
                default:
                    return perskaiciuotosGyvybes;
            }
        }

        public double veikejoGyvybes(double gyvybes, double sarvai, int lygis)
        {
            perskaiciuotosGyvybes = gyvybes;

            if (sarvai >= perskaiciuotosGyvybes * 0.10)
                perskaiciuotosGyvybes += sarvai / gyvybes;
            else perskaiciuotosGyvybes -= perskaiciuotosGyvybes * 0.10;
            if (lygis >= 10)
                perskaiciuotosGyvybes *= 1.1;
            return perskaiciuotosGyvybes;
        }
    }
}
