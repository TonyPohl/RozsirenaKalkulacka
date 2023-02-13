using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozsirenaKalkulacka
{
    internal class DveCisla
    {
        double cislo1;
        double cislo2;

        /// <summary>
        /// Zadání čísel
        /// </summary>
        public void ZadejCisla()
        {
            Console.WriteLine("Zadejte první číslo: ");            
            while (!double.TryParse(Console.ReadLine(), out cislo1))
                Console.WriteLine("Neplatná hodnota, zadejte prosím číslo.");

            Console.WriteLine("Zadejte druhé číslo: ");           
            while (!double.TryParse(Console.ReadLine(), out cislo2))
                Console.WriteLine("Neplatná hodnota, zadejte prosím číslo.");
        }
        /// <summary>
        /// Výběr operace(součet, rozdíl, součin, podíl)
        /// </summary>
        public void VyberOperaci()
        {
            Console.WriteLine("Vyberte operaci pro daná čísla: ");
            Console.WriteLine("1 - Sčítání\n2 - Odčítání\n3 - Násobení\n4 - Dělení");
        }

        public void Secti()
        {
            Console.WriteLine(cislo1 + cislo2);
        }

        public void Odecti()
        {
            Console.WriteLine(cislo1 - cislo2);
        }

        public void Nasob()
        {
            Console.WriteLine(cislo1 * cislo2);
        }

        public void Vydel()
        {
            if (cislo1 == 0 || cislo2 == 0)
                Console.WriteLine("Nelze dělit s nulou!");
            else
                Console.WriteLine(cislo1 / cislo2);
        }
    }

}
