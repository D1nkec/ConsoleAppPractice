using ConsoleAppPractice.Metode;

namespace ConsoleAppPractice
{


    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nIzaberite zadatak:");
                Console.WriteLine("1. Izračunaj prosjek brojeva");
                Console.WriteLine("2. Zbroj znamenki brojeva");
                Console.WriteLine("3. Obrnuti redoslijed znakova u riječima rečenice");
                Console.WriteLine("4. Pronađi sva slova u rečenici");
                Console.WriteLine("5. Zamijeni vrijednosti dva broja");
                Console.WriteLine("6. Zamijeni slova u rečenici");
                Console.WriteLine("7. Pronađi najveći i najmanji broj");
                Console.WriteLine("8. Pronađi palindrom riječi");
                Console.WriteLine("9. Izlaz");
                Console.Write("Izbor: ");

                string izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        IzracunajProsjek.UnosBrojevaIZracunProsjeka();
                        break;

                    case "2":
                        ZbrojZnamenkiBrojeva();
                        break;

                    case "3":
                        ObrniRedoslijedZnakovaURecenicama();
                        break;

                    case "4":
                        PronadiSvaSlovaURecenici();
                        break;

                    case "5":
                        ZamijeniVrijednostiDvaBroja();
                        break;

                    case "6":
                        ZamijeniSlovaURecenici();
                        break;

                    case "7":
                        PronadiNajveciINajmanjiBroj();
                        break;

                    case "8":
                        PronadiPalindromRijeciURecenici();
                        break;

                    case "9":
                        return;


                    default:
                        Console.WriteLine("Pogrešan izbor, pokušaj ponovo.");
                        break;
                }
            }
        }


        static void ZbrojZnamenkiBrojeva()
        {
            string unos;
            while (true)
            {
                Console.Write("Unesite broj (ili 'kraj' za završetak): ");
                unos = Console.ReadLine();
                if (unos.ToLower() == "kraj")
                    break;
                if (int.TryParse(unos, out int broj))
                {
                    int zbrojZnamenki = IzracunajZbrojZnamenki(broj);
                    Console.WriteLine($"Zbroj znamenki broja {broj} je: {zbrojZnamenki}");
                }
                else
                    Console.WriteLine("Molimo unesite važeći broj.");
            }
        }
        static int IzracunajZbrojZnamenki(int broj)
        {
            int zbroj = 0;
            while (broj != 0)
            {
                zbroj += broj % 10;
                broj /= 10;
            }
            return zbroj;
        }


        static void ObrniRedoslijedZnakovaURecenicama()
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            string obrnutaRecenica = ObrniRedoslijedZnakova(recenica);
            Console.WriteLine(obrnutaRecenica);
        }
        static string ObrniRedoslijedZnakova(string recenica)
        {
            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                char[] znakovi = rijeci[i].ToCharArray();
                Array.Reverse(znakovi);
                rijeci[i] = new string(znakovi);
            }
            return string.Join(" ", rijeci);
        }


        static void PronadiSvaSlovaURecenici()
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            string slova = PronadiSlova(recenica);
            Console.WriteLine(slova);
        }
        static string PronadiSlova(string recenica)
        {
            HashSet<char> slovaSet = new HashSet<char>();
            foreach (char c in recenica)
            {
                if (char.IsLetter(c))
                    slovaSet.Add(char.ToLower(c));
            }
            return new string(new List<char>(slovaSet).ToArray());
        }


        static void ZamijeniVrijednostiDvaBroja()
        {
            Console.Write("Unesite broj a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj b: ");
            int b = int.Parse(Console.ReadLine());

            ZamijeniVrijednosti(ref a, ref b);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
        static void ZamijeniVrijednosti(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void ZamijeniSlovaURecenici()
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            Console.Write("Unesite prvo slovo: ");
            char prvoSlovo = char.Parse(Console.ReadLine());
            Console.Write("Unesite drugo slovo: ");
            char drugoSlovo = char.Parse(Console.ReadLine());

            string novaRecenica = ZamijeniSlova(recenica, prvoSlovo, drugoSlovo);
            Console.WriteLine(novaRecenica);
        }
        static string ZamijeniSlova(string recenica, char prvoSlovo, char drugoSlovo)
        {
            return recenica.Replace(prvoSlovo, drugoSlovo);
        }


        static void PronadiNajveciINajmanjiBroj()
        {
            List<int> brojevi = new List<int>();
            string unos;
            while (true)
            {
                Console.Write("Unesite broj (ili 'kraj' za završetak): ");
                unos = Console.ReadLine();
                if (unos.ToLower() == "kraj")
                    break;
                if (int.TryParse(unos, out int broj))
                    brojevi.Add(broj);
                else
                    Console.WriteLine("Molimo unesite važeći broj.");
            }

            if (brojevi.Count > 0)
            {
                int najveci = PronadiNajveci(brojevi);
                int najmanji = PronadiNajmanji(brojevi);
                Console.WriteLine($"Najveći broj je: {najveci}");
                Console.WriteLine($"Najmanji broj je: {najmanji}");
            }
            else
            {
                Console.WriteLine("Nema unesenih brojeva.");
            }
        }
        static int PronadiNajveci(List<int> brojevi)
        {
            int najveci = brojevi[0];
            foreach (int broj in brojevi)
            {
                if (broj > najveci)
                    najveci = broj;
            }
            return najveci;
        }
        static int PronadiNajmanji(List<int> brojevi)
        {
            int najmanji = brojevi[0];
            foreach (int broj in brojevi)
            {
                if (broj < najmanji)
                    najmanji = broj;
            }
            return najmanji;
        }


        static void PronadiPalindromRijeciURecenici()
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            int brojPalindroma = PronadiPalindromRijeci(recenica);
            Console.WriteLine($"Broj palindroma u rečenici: {brojPalindroma}");
        }
        static int PronadiPalindromRijeci(string recenica)
        {
            string[] rijeci = recenica.Split(' ');
            int brojPalindroma = 0;
            foreach (string rijec in rijeci)
            {
                if (JePalindrom(rijec))
                    brojPalindroma++;
            }
            return brojPalindroma;
        }
        static bool JePalindrom(string rijec)
        {
            int duzina = rijec.Length;
            for (int i = 0; i < duzina / 2; i++)
            {
                if (rijec[i] != rijec[duzina - 1 - i])
                    return false;
            }
            return true;

        }


    }
}
