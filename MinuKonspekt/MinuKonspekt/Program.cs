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




        }
    }
}