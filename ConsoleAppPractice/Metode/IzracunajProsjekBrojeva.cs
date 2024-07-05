using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice.Metode
{
    public class IzracunajProsjek
    {
        public static void UnosBrojevaIZracunProsjeka()
        {
            List<double> brojevi = new List<double>();
            string unos;
            while (true)
            {
                Console.Write("Unesite broj (ili 'zadnji' za kraj): ");
                unos = Console.ReadLine();
                if (unos.ToLower() == "zadnji")
                    break;
                if (double.TryParse(unos, out double broj))
                    brojevi.Add(broj);
                else
                    Console.WriteLine("Molimo unesite važeći broj.");
            }

            double prosjek = IzracunajProsjekBrojeva(brojevi);
            Console.WriteLine($"Prosjek unesenih brojeva je: {prosjek}");
        }

        static double IzracunajProsjekBrojeva(List<double> brojevi)
        {
            if (brojevi.Count == 0) return 0;
            double suma = 0;
            foreach (var broj in brojevi)
            {
                suma += broj;
            }
            return suma / brojevi.Count;
        }
    }
}