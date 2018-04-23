using System;
namespace Day4
{
    public class Atrums
    {
        public void AtrumsIR()
        {
            Console.Write("Ievadi attālumu (metros): ");
            int attalums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi patērētās stundas: ");
            int stundas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi patērētās minūtes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi patērētās sekundes: ");
            int sekundes = Convert.ToInt32(Console.ReadLine());

            int koplaiks = sekundes + minutes * 60 + stundas * 3600;
            Console.WriteLine("Kopējais laiks sekundēs ir " + koplaiks);
            //ja dalīšana tad lietojam double, jo būs kaut kas aiz komanta
            double atrums = (double)attalums / koplaiks;
            Console.WriteLine("ātrums m/s ir " + atrums);

            double attalumskm = attalums / 1000d; // d - izmantot decimālskaitli.
            Console.WriteLine("attālums km ir " + attalumskm);

            double atrumskmh = atrums * 18 / 5;
            Console.WriteLine("ātrums km/h ir " + atrumskmh);

            double attalumsjudzes = attalumskm * 0.621371;
            Console.WriteLine("Attālums jūdzēs ir " + attalumsjudzes);

        }
    }
}
