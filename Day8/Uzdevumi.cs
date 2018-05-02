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
            Console.WriteLine("Dalījums = " + ((double)skaitlis1 / skaitlis2));

            //int min = Math.Min(skaitlis1, skaitlis2);
            // int min = skaitlis1 < skaitlis2 ? skaitlis1 : skaitlis2;
            if (skaitlis1 < skaitlis2)
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

            int[] masivs = { 1, 10, 10, 2 };
            //cita iespēja - int[] jaunaisMasivs = new int[masivs.Lenght];
            //int pozicija = 0
            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] != skaitlis)
                {
                    Console.WriteLine(masivs[i]);
                }
            }
        }

        //divi cikli - 3. uzd - jau bija tāds uzdevums - 6.diena trīsstūris

        public void CiparuSumma()
        {
            string skaitlis = "1342452";
            int summa = 0;
            foreach(char cipars in skaitlis)
            {
                int skaitlisksCipars = Convert.ToInt32(cipars.ToString());
                summa += skaitlisksCipars;

            }
            Console.Write(summa);
        }

        public void Parole()
        {
            String ievaditaParole = "lskhfglsghs134";
            int parolesGarums = ievaditaParole.Length;
            int LielieBurti = 0;
            int cipari = 0;

            foreach(char simbols in ievaditaParole)
            {
                if(simbols >= 'A' && simbols <= 'Z')
                {
                    LielieBurti++;
                }
                else if(simbols >= '0' && simbols <= '9')
                {
                    cipari++;
                }
            }
            if(parolesGarums >= 10 && cipari>= 2 && LielieBurti >= 2)
            {
                Console.WriteLine("Parole ir derīga");
            }
            else
            {
                Console.WriteLine("Parole nav derīga");
            }
        }

    }
}
