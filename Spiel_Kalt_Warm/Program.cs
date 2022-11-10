namespace Spiel_Kalt_Warm;
class Program
{
    static void Main(string[] args)
    {                         
        Start();
    }

    static int Start()
    {
        // User-Eingabe anlegen: DAU, Ersteingabe, Treffer?

        int zahl = ZufallsZahl();
        bool check;
        int userEingabe1 = 0;
        return userEingabe1;

        do
        {
            Console.Clear();

        // User-Eingabe
            
            Console.Clear();
            Console.WriteLine("Gebe eine Zahl zwischen 1 und 100 ein: \n");
            check = int.TryParse(Console.ReadLine(), out userEingabe1);

        // Dau-Sicherheit

            if (!check)
            {
                Console.WriteLine("\nNur Ziffern eingeben, du Analphabet!");
                Console.WriteLine("Weiter mit beliebige Taste...");
                Console.ReadKey();
            }
            
        } while (!check);

        // Treffer ?

        if (userEingabe1 == zahl)
        {
            Console.WriteLine("Du hast gewonnen!");
        }
        else
        {
            ColdWarm();
        }
    }

    static int ZufallsZahl()
    {
        // Zufallszahl generieren (1-100)#

        Random zufallsZahl = new Random();
        return zufallsZahl.Next(1, 101);
        
        
    }


    // Ab der 2. Eingabe => Vergleich: Treffer?, wärmer, kälter
    static void ColdWarm()
    {
        bool check;
        int userEingabe2 = 0;

        do
        {          
     // 2.User-Eingabe

            Console.Clear();
            Console.WriteLine("Gebe \"nochmal\" eine Zahl zwischen 1 und 100 ein: \n");
            check = int.TryParse(Console.ReadLine(), out userEingabe2);

     // Dau-Sicherheit für 2.Eingabe

            if (!check)
            {
                Console.WriteLine("\nNur Ziffern eingeben, du Analphabet!");
                Console.WriteLine("Weiter mit beliebige Taste...");
                Console.ReadKey();
            }

        } while (!check);

    // Vergleich User-Eingabe1 und User-Eingabe2

        if (userEingabe2 == Start())
        {

        }

    }

    // Wiederholung
    // Bei Sieg: Ausgabe + Anzahl der Versuche
}

