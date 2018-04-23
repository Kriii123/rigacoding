using System;
namespace MajasDarbi
{
    public class Uzdevumi
    {
        public void Pilngadiba()
        {
            Console.Write("Ieraksti savu vecumu: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());


            if (skaitlis == 18 || skaitlis > 18)
            {
                Console.WriteLine("Tu esi pilngadīgs!");

            }
            else
            {
                Console.WriteLine("Tu esi nepilngadīgs!");
            }
        }
        public void VidejaVertiba()
        {
            Console.Write("Ieraksti pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ieraksti otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ieraksti trešo skaitli: ");
            int skaitlis3 = Convert.ToInt32(Console.ReadLine());

            int skaitlis = skaitlis1 + skaitlis2 + skaitlis3;
            Console.WriteLine("Šo skaitļu vidējā vērtība ir " + (double)skaitlis / 3);

        }
        public void MervienibuMaina()
        {
            Console.Write("Ievadi, cik grādi šobrīd ir ārā: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi, kādā mērvienībā ir temperatūra - celsija (C) vai fārenheita (F): ");
            string mervieniba = Console.ReadLine();
            //pārvēršam uz lielajiem burtiem.
            mervieniba = mervieniba.ToUpper();

            if(mervieniba == "C")
            {
                int farenheits = skaitlis * 9 / 5 + 32;
                Console.WriteLine("Ja celsija skalā ir " + skaitlis 
                                  + " grādi, tad fārenheita skalā tas būs "
                                  + farenheits);
            }
            else if(mervieniba == "F")
            {
                int celsijs = (skaitlis - 32) * 5 / 9;
                Console.WriteLine("Ja fārenheita skalā ir " + skaitlis 
                                  + " grādi, tad celsija skalā būs " + celsijs);
            }
            else
            {
                Console.WriteLine("Tu esi ievadījis nepareizu mērvienību - jāievada C vai F!");
            }
            /*
        }
        public void ParaSkaitlis( int skaitlis5)
        {
            int paraskaitlis;
            if (paraskaitlis = skaitlis5 / 2 ==  )
            {
                
            }*/

        }
        public void IntervalaParbaude()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            //1. variants
            if (skaitlis >= -50)
            {
                if (skaitlis <= 50)
                {
                    Console.WriteLine("skaitlis ir atbildtošajā intervālā");

                }
                else
                {
                    Console.WriteLine("skaitlis nav atbildtošajā intervālā");
                }
            }
            else
            {
                Console.WriteLine("skaitlis nav atbildtošajā intervālā");
            }

            // 2. variants
            if (skaitlis >= -50)
            {
                if (skaitlis <= 50)
                {
                    Console.WriteLine("skaitlis ir atbildtošajā intervālā");
                    return; // pārtraucam funkcijas izpildi
                }
            }

            Console.WriteLine("skaitlis nav atbildtošajā intervālā");
            //3. variants
            // && - un!!!
            if (skaitlis >= -50 && skaitlis <= 50)
            {
                Console.WriteLine("skaitlis ir atbildtošajā intervālā");

            }
            else
            {
                Console.WriteLine("skaitlis nav atbildtošajā intervālā");
            }
        }
        public void VaiIrPara()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis % 2 == 0)
            {
                Console.WriteLine("pāra skaitlis");
            }
            else
            {
                Console.WriteLine("nav pāra skaitlis");

            }
        }
        public void Rombs()
        {
            Console.Write("Ievadi rindu skaitu: ");
            int rindas = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= rindas; i++)
            {
                for (int ii = 1; ii <= rindas - i; ii++) 
                    Console.Write(" ");
          
                for (int ii = 1; ii <= 2 * i - 1;ii++)
                    Console.Write("*");

              
            }

        }
    }
}
