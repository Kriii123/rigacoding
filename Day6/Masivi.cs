using System;
namespace Day6
{
    public class Masivi
    {
        // Masīvi 
        //katram masīva elementam ir savs numurs un numerācija sākas no 0
        //veidojot masīvu ir jāpasaka cik elemeti iekšā būs, bet visus elementus var neizpildīt, bet vairāk nedrīkst pildīt
        //izmanto, kur it vairāki ieraksti
        public static void ApgrieztsMasivs()
        {
            Console.Write("Cik skaitļus tu norādīsi?: ");
            int cik = Convert.ToInt32(Console.ReadLine());

            int[] skaitli = new int[cik];

            for (int i = 0; i < cik; i++)
            {
                Console.Write("Ievadi " + (i + 1) + ". skaitli: ");
                skaitli[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = cik - 1; i >= 0; i--)
            {
                Console.WriteLine(skaitli[i]);
            }
        }
        public static void ViensSkaitlis()
        {
            Console.Write("Ieraksti skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            int[] skaitluMasivs = { 0, 10, 20, 30, 40, 50 };

            /*for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] == skaitlis)
                {
                    Console.WriteLine("Atrodas masīvā");
                    Console.WriteLine("Pozīcija = " + i);
                    return;
                    //beidz funkciju

                }


            }
            Console.WriteLine("Skaitlis nav atrasts!");*/

            int pozicija = Array.IndexOf(skaitluMasivs, skaitlis);

            //saīsināta funkcija, kas atgriež skaitli
            if (pozicija == -1)
            {
                Console.WriteLine("Skaitlis nav atrasts!");
            }
            else
            {
                Console.WriteLine(pozicija);
            }


        }

    }
}
