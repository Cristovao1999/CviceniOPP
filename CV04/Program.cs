using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV04
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                                   + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                                   + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                                   + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                                   + "posledni veta!\n";
            StringStatistics textem = new StringStatistics();
            Console.WriteLine(testovaciText + "\n");
            Console.WriteLine($"Pocet slov: {textem.pocetSlov(testovaciText)}");
            Console.WriteLine($"Pocet radku: {textem.pocetRadku(testovaciText)}");
            Console.WriteLine($"Pocet vet: {textem.pocetVet(testovaciText)}");
            Console.ReadLine();

        }
    }
}
