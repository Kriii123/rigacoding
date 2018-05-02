using System;
namespace MajasDarbi2
{
    public class Uzdevumi
    {
        public void ParaSkaitli()
        {
            Console.Write("Ievadi 1. skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi 2. skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            for (int i = skaitlis1; i <= skaitlis2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int ii = skaitlis2; ii <= skaitlis1; ii++)
            {
                if (ii % 2 == 0)
                {
                    Console.WriteLine(ii);
                }
            }
        }

    }
}

