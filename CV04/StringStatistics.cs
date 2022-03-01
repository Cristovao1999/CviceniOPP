using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV04
{
    internal class StringStatistics
    {
        protected int PocetSlov = 0, PocetRadku = 0, PocetVet = 0;
        public int pocetSlov(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',' || text[i] == '.' || text[i] == '!' || text[i] == '?' || text[i] == ' ')
                {
                    PocetSlov = PocetSlov + 1;
                }
            }
            return PocetSlov;
        }
        //hotovo
        public int pocetRadku(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    PocetRadku = PocetRadku + 1;
                }
            }
            return PocetRadku;
        }
        //hotovo
        public int pocetVet(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                {
                    PocetVet = PocetVet + 1;
                }
            }
            return PocetVet;
        }
    }
}
