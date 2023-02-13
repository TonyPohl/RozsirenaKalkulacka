namespace RozsirenaKalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Vítejte v Tonyho rozšířené kalkulačce!\n======================================\n");
           
            bool pokracovat = true;
            while (pokracovat)
            {
                Console.WriteLine("Vyberte, s kolika čísly budete chtít operovat: (1,2)");
                int pocetCisel;
                while (!int.TryParse(Console.ReadLine(), out pocetCisel))
                    Console.WriteLine("Neplatné číslo, prosím zadejte znovu.");

                // OPERACE PRO JEDNO ČÍSLO
                if (pocetCisel == 1)
                {
                    JednoCislo jednoCislo = new JednoCislo();
                    jednoCislo.ZadejCislo();
                    jednoCislo.VyberOperaci();

                    int volba;
                    while (!int.TryParse(Console.ReadLine(), out volba))
                        Console.WriteLine("Neplatné číslo, prosím zadejte znovu.");

                    switch (volba)
                    {
                        case 1: // druhá odmocnina z čísla
                            jednoCislo.Odmocni();
                            break;

                        case 2: // umocnění na druhou
                            jednoCislo.UmocniNaDruhou();
                            break;

                        case 3: // stupně na radiány
                            jednoCislo.StupneNaRadiany();
                            break;

                        case 4: // radiány na stupně
                            jednoCislo.RadianyNaStupne();
                            break;

                        case 5: // výpočet faktoriálu
                            jednoCislo.SpoctiFaktorial();
                            break;

                        default:
                            Console.WriteLine("Neplatná hodnota, zvolte číslo mezi 1 - 4.");
                            continue;
                    }
                }
                // OPERACE PRO DVĚ ČÍSLA
                else if (pocetCisel == 2)
                {
                    DveCisla dveCisla = new DveCisla();
                    dveCisla.ZadejCisla();
                    dveCisla.VyberOperaci();
                    int volba2;
                    while (!int.TryParse(Console.ReadLine(), out volba2))
                        Console.WriteLine("Neplatné číslo, prosím zadejte znovu.");

                    switch (volba2)
                    {
                        case 1: // součet
                            dveCisla.Secti();
                            break;
                        case 2: // rozdíl
                            dveCisla.Odecti();
                            break;
                        case 3: // součin
                            dveCisla.Nasob();
                            break;
                        case 4: // podíl
                            dveCisla.Vydel();
                            break;

                        default:
                            Console.WriteLine("Neplatná hodnota, zvolte číslo mezi 1 - 4.");
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Zadali jste nesprávné číslo, zvolte prosím 1 nebo 2.");
                }
                Console.WriteLine("Přejete si pokračovat? [ano / ne]");
                bool platnaVolba = false;
                while (!platnaVolba)
                {
                    switch (Console.ReadLine())
                    {
                        case "ano":
                            platnaVolba = true;
                            pokracovat = true;
                            break;

                        case "ne":
                            platnaVolba = true;
                            pokracovat = false;
                            break;

                        default:
                            Console.WriteLine("Neplatná volba, zadejte prosím ano/ne");
                            break;
                    }
                }
            }
            Console.WriteLine("Děkuji za použití kalkulačky, hezký den!");
        }
    }
}


