namespace Spiel_Kalt_Warm
{
    class Program
    {
        /*
        ## DONE ##
               Generierung (1-100)
               - Random

        ## TO-DO ##

        * Eingabe 1-100
            - One Input to rule them all
        * Überprüfung
            - Eingabe, alte Zahl, neue Zahl
        * Ausgabe
        */

        static int zufallsZahl;
        static int alteEingabe = 0;


        static void Main(string[] args)
        {
            Durchlauf();
        }

        static int Generierung()
        {
            // Generierung random (1-100)

            Random zufallsZahl = new Random();
            return zufallsZahl.Next(1, 101);

        }

        static int Eingabe()
        {
            int userEingabe = 0;
            bool check;


            do
            {
                Console.WriteLine("User Eingabe");
                check = int.TryParse(Console.ReadLine(), out userEingabe);

                if (!check)
                {
                    Console.WriteLine("Depp keine Buchstaben eingeben!");
                }
                else if (userEingabe == 0)
                {
                    Console.WriteLine("Du Anal-phabet da steht 1-100!");
                }

            } while (!check);
            return userEingabe;


        }

        static bool Ueberpruefen(int parameter)
        {
            int eingabe = parameter;
            int gesuchteZahl = zufallsZahl;

            if (eingabe == gesuchteZahl)
            {
                return true;
            }

            int alt = Math.Abs(alteEingabe - gesuchteZahl); // (30 - 50) 20 "Schritte bis gesuchteZahl"
            int neu = Math.Abs(eingabe - gesuchteZahl);     // (25 - 50) 25 "Schritte bis gesuchteZahl"
                                                            // gesucht = 50 Bsp.

            if (alt < neu)  //Wenn schritte 
            {
                Console.WriteLine("Kalt");
            }
            else if (alt > neu)
            {
                Console.WriteLine("Warm");
            }

            alteEingabe = eingabe;

            return false; // gewonnen (Eingabe == zuFallszahl) true - verloren false
        } //parameter siehe*1  Funktion der Methode= Gibt raus 0||1, ob der User gewonnen hat oder nicht!

        static void Durchlauf()
        {
            bool gewonnen = false; // er hat nicht gewonnen
            zufallsZahl = Generierung();
            do
            {
                if (Ueberpruefen(Eingabe()))
                {
                    gewonnen = true;
                }
            } while (!gewonnen); //Wenn es nicht true ist mach was zwischen Klammern


            Console.WriteLine("GEWONNEN!");
            Console.ReadKey();


        }

    }

    /* 
     *1 =
    Du übergebe der Methode Ueberpruefen() einen Parameter [die User Eingabe bzw. int von Eingabe()] zur weiteren Verarbeitung.


     */


}
