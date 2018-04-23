using System;
namespace Day8
{
    public class Uzdevumi
    {
        public void Darbibas()
        {
            Console.Write("Ievadi 1. skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi 2. skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Summa = " + (skaitlis1 + skaitlis2));
            Console.WriteLine("Starpība = " + (skaitlis1 - skaitlis2));
            Console.WriteLine("Reizinājums = " + (skaitlis1 * skaitlis2));
            Console.WriteLine("Dalījums = " + ((double) skaitlis1 / skaitlis2));

            if(skaitlis1<skaitlis2)
            {
                Console.WriteLine("Min = " + skaitlis1);
                Console.WriteLine("Max = " + skaitlis2);
            }
            else
            {
                Console.WriteLine("Min = " + skaitlis2);
                Console.WriteLine("Max = " + skaitlis1);
            }

            double vid = ((double)skaitlis1 + skaitlis2) / 2;
            Console.WriteLine("Vidējā vērtība = " + vid);
               
        }
        public void Iznemot10()
        {
            int skaitlis = 10;

            int[] masivs = {1,10,10,2};
            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] != skaitlis)
                {
                    Console.WriteLine(masivs[i]);
                }
            }
        }


    }
}
