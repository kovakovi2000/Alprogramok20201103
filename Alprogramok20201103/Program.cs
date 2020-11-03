using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Alprogramok20201103
{
    class Program
    {
        private static int[] SharediArray = new int[100];
        public static Random RND = new Random();
        private static string pw = "";
        static void Main(string[] args)
        {
            /*
             * 1. Írjunk eljárást, mely egy 100 elemű tömböt feltölt kétjegyű véletlen-számokkal és egy másikat, amely egy 100 elemű
             * tömb elemeit a képernyőre írja.
             */
            int[] temp = new int[100];
            iMetods.FillWithRands(ref temp);
            iMetods.PrintAll(temp);
            iMetods.WaitNClear();

            /*
             * 2. Az előbbi eljárást egy megosztott tömbön végezze el a feladatát.
             * 3. Írjunk egy másik eljárást is, amely kiírja a megosztott tömb elemeit!
             */
            iMetods.FillWithRands(ref SharediArray);
            iMetods.PrintAll(SharediArray);
            iMetods.WaitNClear();

            /*
             * 4. Írjunk eljárást (RandomHelyreIr), mely a képernyő egy véletlenszerűen kiválasztott helyére kiír egy * karaktert!
             * 5. Írjunk eljárást (RandomSzin), mely 5 szín közül véletlenszerűen beállítja valamelyikre a betűszínt!
             * 6. Az előbbi két eljárás felhasználásával rakjunk ki a képernyőre 200 *-ot véletlenszerűen elhelyezve.
             */
            for (int i = 0; i < 200; i++)
            {
                iMetods.RandomSzin();
                iMetods.RandomHelyreIr();
            }
            iMetods.WaitNClear();

            /*
             * 7. Írjunk függvényt (RandomChar), mely véletlenszerűen generál egy karaktert az ASCII kódtáblából úgy, hogy a karakter 
             * csak az angol ábécé nagybetűi közül lehet. (65-90)
             * 8. Az előbbi függvény felhasználásával készítsünk függvényt, mely véletlenszerűen generál egy 6 karakteres jelszót, majd
             * ennek felhasználásával írjunk ki a képernyőre egy véletlen jelszót.
             */
            for (int i = 0; i < 5; i++)
            {
                pw += iMetods.RandomChar();
            }
            Console.WriteLine(pw);
            iMetods.WaitNClear();

            /*
             * 9. Írjunk függvényt (TombKever), mely egy tömb elemeit összekeveri (véletlenszerűen megváltoztatja az elemek
             * sorrendjét). Ennek segítségével készítsünk függvényt, amely visszaadja az INFORMATIKA szó egy anagrammáját!
             */
            Console.WriteLine(iMetods.TombKever("INFORMATIKA"));
            iMetods.WaitNClear();

            /*
             * 10. Készítsünk olyan függvényt, amely egy feltöltött tömb elemeinek ismeretében megadja azt a legszűkebb intervallumot,
             * amelyből a tömb elemek származnak (azaz megadja a tömb legkisebb és legnagyobb elemét)!
             */
            //PrintMinMax(new int[] Array);

            /*
             * 11. Készítsünk Osztalyoz( ) nevű eljárást, mely a paraméterként megadott (számjegyes) osztályzathoz kiírja a szöveges
             * osztályzatot. (1 - elégtelen, 2 - elégséges, 3 - közepes, 4 - jó, 5 - jeles) Hívjuk meg az eljárás különböző paraméterekkel.
             */
            for (int i = 0; i < 10; i++)
                Console.WriteLine(iMetods.Osztalyoz(RND.Next(0, 5)));
            iMetods.WaitNClear();

            /*
             * 12. Készítsünk HonapSzama( ) nevű eljárást, mely a paraméterként megadott szöveges hónapnévhez kiírja a hónap
             * sorszámát! Hívjuk meg az eljárás különböző paraméterekkel.
             */

            Console.WriteLine(iMetods.HonapSzama("január"));
            Console.WriteLine(iMetods.HonapSzama("június"));
            Console.WriteLine(iMetods.HonapSzama("valami"));
            iMetods.WaitNClear();

            /*
             * 13. Készítsünk KerTer( ) nevű függvényt, mely a paraméterként megadott két pozitív számhoz kiszámítja a téglalap
             * kerületét és területét!
             */
            //KerTer(new int x, new int y);

            /*
             * 14. Készítsünk HaromszogE( ) nevű függvényt, mely a paraméterként megadott 3 számhoz megadja, hogy azokból
             * szerkeszthető-e háromszög. Hívjuk meg az eljárást különböző paraméterekkel.
             */
            Console.WriteLine("Háromszög - a:10 b:10 c:10 | " + (iMetods.HaromszogE(10, 10, 10) ? "lehetséges" : "lehetetlen"));
            Console.WriteLine("Háromszög - a:10 b:20 c:10 | " + (iMetods.HaromszogE(10, 20, 10) ? "lehetséges" : "lehetetlen"));
            Console.WriteLine("Háromszög - a:1 b:1 c:10 | " + (iMetods.HaromszogE(1, 1, 10) ? "lehetséges" : "lehetetlen"));
            iMetods.WaitNClear();


        }
    }

    class iMetods
    {
        public static void FillWithRands(ref int[] iArray)
        {
            for (int i = 0; i < iArray.Length; i++)
                iArray[i] = Program.RND.Next(10, 100);
        }

        public static void PrintAll(int[] iArray)
        {
            for (int i = 0; i < iArray.Length; i++)
                Console.WriteLine(iArray[i]);
        }

        public static void RandomHelyreIr()
        {
            Console.SetCursorPosition(Program.RND.Next(0, Console.WindowWidth), Program.RND.Next(0, Console.WindowHeight));
            Console.Write("*");
        }

        public static void RandomSzin()
        {
            Console.ForegroundColor = (ConsoleColor)Program.RND.Next(0, 5);
        }

        public static char RandomChar()
        {
            return (char)Program.RND.Next(65, 91);
        }

        public static string TombKever(string input)
        {
            return new string(input.ToCharArray().OrderBy(x => Program.RND.Next()).ToArray());
        }

        public static void PrintMinMax(int[] iArray)
        {
            Console.WriteLine("alsó érték: " + iArray.Min() + " | Felső érték: " + iArray.Max());
        }

        public static string Osztalyoz(int grade)
        {
            switch (grade)
            {
                case 1:
                    return "elégtelen";
                case 2:
                    return "elégséges";
                case 3:
                    return "közepes";
                case 4:
                    return "jó";
                case 5:
                    return "jeles";
                default:
                    return "Invalid parameter";
            }
        }

        public static int HonapSzama(string input)
        {
            return DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(DateTimeFormatInfo.CurrentInfo.MonthNames.Where(x => x == input).FirstOrDefault()) + 1;
        }

        public static void KerTer(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Invalid parameter");
                return;
            }

            Console.WriteLine("Kerület: " + ( (a + b) * 2 ) + " | Terület: " + (a * b));
        }

        public static bool HaromszogE(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || c + b <= a)
                return false;
            return true;
        }

        public static void WaitNClear()
        {
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
