namespace RozsirenaKalkulacka
{
    internal class JednoCislo
    {
        public int cislo;
        /// <summary>
        /// Zadání čísla
        /// </summary>
        public void ZadejCislo()
        {
            Console.WriteLine("Zadejte číslo: ");
            while (!int.TryParse(Console.ReadLine(), out cislo))
                Console.WriteLine("Neplatná hodnota, zadejte prosím číslo.");
        }
        /// <summary>
        /// Výběr operace(odmocnina, umocnění na druhou, převod stupňů na radiány, radiánů na stupně, výpočet faktoriálu)
        /// </summary>
        public void VyberOperaci()
        {
            Console.WriteLine("Vyberte si operaci s číslem: ");
            Console.WriteLine("1 - Druhá odmocnina z čísla\n2 - Umocnění čísla na druhou\n3 - Převod stupňů na radiány\n4 - Převod radiánů na stupně\n5 - Výpočet faktoriálu");
        }
        
        public void Odmocni()
        {
            Console.WriteLine(Math.Sqrt(cislo));
        }

        public void UmocniNaDruhou()
        {
            Console.WriteLine(Math.Pow(cislo, 2));
        }

        public void StupneNaRadiany()
        {
            Console.WriteLine((Math.PI / 180) * cislo);
        }

        public void RadianyNaStupne()
        {
            Console.WriteLine((180 / Math.PI) * cislo);
        }

        public void SpoctiFaktorial()
        {
            int faktorial = 1;
            for (int i = 1; i <= cislo; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine(faktorial);
        }
    }
}
