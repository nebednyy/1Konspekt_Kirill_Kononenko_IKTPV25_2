using System.ComponentModel.Design;

namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Muutujad, Matemalised tehted, IF, ELSE IF JA ELSE
            Console.WriteLine();
            string name = Console.ReadLine();
            if (name != null)
            {
                Console.WriteLine("Tere " + name + "!");
            }
            else if (name == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma name");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma name");
            }

            //2. tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp 
            Console.WriteLine(name + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());
            if (kasutajavanus > 0)
            {
                if (kasutajavanus < 18)
                {
                    Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma😊");
                }
                else
                {
                    Console.WriteLine("Saad osta Monsterit , Yippe 😡😡");
                }
                if (kasutajavanus > 0 && kasutajavanus < 18)
                {
                    Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma😊");
                }
                else
                {
                    Console.WriteLine("Saad osta Monsterit , Yippe 😡😡");
                }
                Console.WriteLine("Sisesta oma pikkus ka, palun, " + name + ":");
                double pikkus = double.Parse(Console.ReadLine());
                if (pikkus < 1.00d)
                {
                    Console.WriteLine("Oled juntsu");
                }
                else if (pikkus < 1.25d && pikkus > 1.00d)
                {
                    Console.WriteLine("Oled peaaegu allameetrimees");
                }
                else if (pikkus < 1.50d && pikkus > 1.25d)
                {
                    Console.WriteLine("OiOi, Päkapikk enam ei olegi " + name + " !");
                }
                else if (pikkus < 1.75d && pikkus > 1.5d)
                {
                    Console.WriteLine("Oled enamasti standardpikkused, kui mitte just natuke lühike");
                }
                else if (pikkus < 2.00d && pikkus > 1.75d)
                {
                    Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
                }
                else if (pikkus > 2.00d)
                {
                    Console.WriteLine("Täievik tulnukas, kuidas pilved välja näevad?");
                }
                else
                {
                    Console.WriteLine("pikkust ei tunta");
                }

            }
            using System;

             class Program
        {
            static void Main()
            {
                bool jätka = true;

                while (jätka)
                {
                    // --- Osa 1: tavaline kalkulaator ---
                    Console.WriteLine("Tere, sisesta esimene arv:");
                    double arv1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Sisesta teine arv:");
                    double arv2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Palun sisesta tehemärk: / * + - ^ ");
                    string tehtetyyp = Console.ReadLine();

                    double tulemus = 0;
                    bool korrektneTehe = true;

                    if (tehtetyyp == "+")
                        tulemus = arv1 + arv2;
                    else if (tehtetyyp == "-")
                        tulemus = arv1 - arv2;
                    else if (tehtetyyp == "*")
                        tulemus = arv1 * arv2;
                    else if (tehtetyyp == "/")
                    {
                        if (arv2 != 0)
                            tulemus = arv1 / arv2;
                        else
                        {
                            Console.WriteLine("Viga: nulliga ei saa jagada!");
                            korrektneTehe = false;
                        }
                    }
                    else if (tehtetyyp == "^")
                        tulemus = Math.Pow(arv1, arv2);
                    else
                    {
                        Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
                        korrektneTehe = false;
                    }

                    if (korrektneTehe)
                        Console.WriteLine("Tulemus: " + tulemus);

                    // --- Puuvilja valik ---
                    Console.WriteLine("Kas sa tahad õuna või banaani?");
                    string vastus = Console.ReadLine();

                    if (vastus == "õuna")
                        Console.WriteLine("Siin on sulle õun :)");
                    else if (vastus == "banaani")
                        Console.WriteLine("Siin on sulle banaan :)");
                    else
                        Console.WriteLine("Sellist puuvilja ma ei tunne.");

                    // --- Osa 2: ringi kalkulaator ---
                    Console.WriteLine("\nTere! See on ringi kalkulaator.");
                    Console.WriteLine("Vali tehe:");
                    Console.WriteLine("1 - Leia pindala (raadiuse järgi)");
                    Console.WriteLine("2 - Leia ümbermõõt (raadiuse järgi)");
                    Console.WriteLine("3 - Leia diameeter (raadiuse järgi)");
                    Console.WriteLine("4 - Leia pindala (diameetri järgi)");
                    Console.WriteLine("5 - Leia raadius (diameetri järgi)");

                    int valik = int.Parse(Console.ReadLine());

                    if (valik == 1)
                    {
                        Console.Write("Sisesta raadius: ");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Pindala = " + (Math.PI * r * r));
                    }
                    else if (valik == 2)
                    {
                        Console.Write("Sisesta raadius: ");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ümbermõõt = " + (2 * Math.PI * r));
                    }
                    else if (valik == 3)
                    {
                        Console.Write("Sisesta raadius: ");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Diameeter = " + (2 * r));
                    }
                    else if (valik == 4)
                    {
                        Console.Write("Sisesta diameeter: ");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine("Pindala = " + (Math.PI * (d / 2) * (d / 2)));
                    }
                    else if (valik == 5)
                    {
                        Console.Write("Sisesta diameeter: ");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine("Raadius = " + (d / 2));
                    }
                    else
                    {
                        Console.WriteLine("Vale valik!");
                    }

                    // --- Küsimus, kas jätkata ---
                    Console.WriteLine("\nKas soovid jätkata? (jah/ei)");
                    string jätkaVastus = Console.ReadLine().ToLower();

                    if (jätkaVastus != "jah")
                        jätka = false;
                }

                Console.WriteLine("Aitäh kasutamast kalkulaatorit! Head päeva!");
            }
        }





    }
}
}