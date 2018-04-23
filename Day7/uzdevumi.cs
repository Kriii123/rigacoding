using System;
using System.Linq;

namespace Day7
{
    public class uzdevumi
    {
        public static void SkaitlisPieci()
        {
            Console.Write("Cik vērtības ievadīsi: ");

            int skaits = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[skaits];

            for (int i = 0; i < skaits; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());

            }
            //for (int ii = 0; ii < masivs.Length; ii++)
            // {
            // int skaitlis = masivs[ii];
            int skaititajs = 0;
            //nodefinējam, ka būs vērtība, kas saskaita, cik ir skaitļi 5
            foreach (int skaitlis in masivs)
            {
                if (skaitlis == 5)
                {
                    skaititajs++;

                }

            }
            Console.WriteLine("Atrasti " + skaititajs + " skaitļi 5.");


        }
        public static void Galvaspilseta()
        {
            Console.Write("Ievadi valsti: ");
            string valsts = Console.ReadLine();

            switch (valsts.ToLower())// pārvērst uz mazajiem burtiem
            {
                case "igaunija":
                    Console.WriteLine("Tallina");
                    break;
                case "somija":
                    Console.WriteLine("Helsinki");
                    break;
                case "ukraina":
                    Console.WriteLine("Kijeva");
                    break;
                case "zviedrija":
                    Console.WriteLine("Stokholma");
                    break;
                case "krievija":
                    Console.WriteLine("Maskava");
                    break;
                default:
                    Console.WriteLine("Galvaspilsēta nav zināma!");
                    break;


            }
        }
        public static void Result()


        {
            try
            {


                Console.Write("Ievadi 1. skaitli: ");
                int skaitlis1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ievadi 2. skaitli ");
                int skaitlis2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kāda būs darbība?: ");
                string darbiba = Console.ReadLine();

                switch (darbiba)
                {
                    case "+":
                        Console.WriteLine("Summa ir " + (skaitlis1 + skaitlis2));
                        break;
                    case "-":
                        Console.WriteLine("Starpiba ir " + (skaitlis1 - skaitlis2));
                        break;
                    case "*":
                        Console.WriteLine("Reizinājums ir " + (skaitlis1 * skaitlis2));
                        break;
                    case "/":
                        if (skaitlis2 == 0)
                        {
                            Console.WriteLine("Darbība nav atļauta - ar 0 dalīt nedrīkst!");
                            Console.WriteLine("Atkārtojam ievadi!");
                            Result();
                            return;
                        }
                        Console.WriteLine("Dalījums ir " + (double)skaitlis1 / skaitlis2);
                        break;
                    default:
                        Console.WriteLine("Nepareizs simbols");
                        Result();
                        break;


                }



            }
            catch (Exception ex) //saglabā kļūdu un parāda pēc tam
            {
                Console.WriteLine("Nepareiza vērtība!");
                Result();
            }
        }
        public static void HighLow()
        {
            Console.Write("Cik vērtības ievadīsi: ");

            int skaits = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[skaits];

            for (int i = 0; i < skaits; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = masivs[0];
            int max = masivs[0];
            foreach (int skaitlis in masivs)//iziet cauri visiem masīva elementiem
                //definēju jaunu mainīgo "skaitlis", kas if funkcijā pārbauda visus skaitļus masīvā
            {
                if (skaitlis < min)
                {
                    min = skaitlis;
                }
                else if (skaitlis > max)
                {
                    max = skaitlis;
                }

            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);

           // int minimums = masivs.Min(); Iebūvētas funkcijas, kuras izmantot min un max atrašanai
            //int maximums = masivs.Max();

        }
    }
}

