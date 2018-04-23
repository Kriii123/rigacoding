using System;
namespace Day5_PraktiskaisDarbs
{
    public class Uzdevumi
    {
        public void DilstosaVirkne()
        {
            Console.WriteLine("Skaitļi dilstošā secībā");
            Console.Write("Ievadi skaitli: ");
            int dilst = Convert.ToInt32(Console.ReadLine());

            for (int skaitli = dilst; skaitli >= 1; skaitli = skaitli - 1)
            {
                Console.WriteLine("Skaitlis " + skaitli);
            }

        }

        public void Modinatajs()
        {
            Console.WriteLine("Cikos būs modinātājs?");
            Console.Write("Ievadi dienu (P,O,T,C,Pk,S,Sv): ");
            string diena = Console.ReadLine();

            Console.Write("Vai Tu esi atvaļinājumā? - Jā/Nē: ");
            string atvalinajums = Console.ReadLine();

            //Console.WriteLine(irAtvalinajums == "Jā" ? "off" : "10:00");
            //? - pārbauda : - else

            if ((diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "Pk") && atvalinajums == "Jā")
            {
                Console.WriteLine("Modinātājs jāliek plkst. 10:00");

            }
            else if ((diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "Pk") && atvalinajums == "Nē")
            {
                Console.WriteLine("Modinātājs jāliek plkst. 7:00");
            }
            else if ((diena == "S" || diena == "Sv") && atvalinajums == "Nē")
            {
                Console.WriteLine("Modinātājs jāliek plkst. 10.00");
            }
            else
            {
                Console.WriteLine("Modinātājs nav jāliek.");
            }
        }
        public void SodaNoteiksana()
        {
            Console.WriteLine("Soda noteikšana");
            Console.Write("Ievadiet ātrumu:");
            int atrums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vai jums šodien ir dzimšanas diena? Jā/Nē: ");
            string dzd = Console.ReadLine();

            if (dzd == "Jā")
            {
                atrums = atrums - 5;
            }
            if (atrums <= 60)
            {
                Console.WriteLine("nav soda");
            }
            else if (atrums > 60 && atrums <= 80)
            {
                Console.WriteLine("neliels sods");
            }
            else
            {
                    Console.WriteLine("Liels sods");

            }
        }
        public void FizzBuzz()
        {
            Console.WriteLine("FizzBuzz");
            Console.Write("Ievadi sākuma vērtību: ");
            int sakums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi beigu vērtību: ");
            int beigas = Convert.ToInt32(Console.ReadLine());

            for (int skailis = sakums; skailis <= beigas; skailis++)
            {
                if (skailis % 3 == 0 && skailis % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (skailis % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (skailis % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }
                else
                {
                    Console.WriteLine(skailis);
                }
            }
        }
        public void Neveiksmigais13()
        {
            Console.WriteLine("Nevieksmīgais 13");  

            int summa = 0;
            for (; ; )
            {
                Console.Write("Ievadi skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if(skaitlis == 13)
                {
                    break;
                }
                summa = summa + skaitlis;

            }
            Console.WriteLine("Summa ir " + summa);

        }
        public void Acite()
        {
            Console.WriteLine("acīte");
            Console.Write("Ievadi 1. skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi 2. skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            if(skaitlis1<= 21 && (skaitlis1> skaitlis2 || skaitlis2 > 21))
            {
                Console.WriteLine(skaitlis1);   
            }
            else if (skaitlis2<= 21 && (skaitlis2 > skaitlis1 || skaitlis1 >21))
            {
               Console.WriteLine(skaitlis2);

            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

