using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Cikli2.Trissturis();
            Masivi.ViensSkaitlis();
            Masivi.ApgrieztsMasivs();

            Piemeri();
            Console.ReadLine();

        }
        public static void Piemeri()
        {
            int?[] skaitluMasivs = new int?[8];
            // jālieto kvadrātiekavas 

            skaitluMasivs[0] = 32;
            skaitluMasivs[2] = 2;
            skaitluMasivs[7] = 34;

            //skaitluMasivs[8] = 9; // šī rinda izmestu kļūdu

            //īss pieraksts
            int[] skaitluMasivs2 = 
            {
                1,4,20,33
            };

            for (int ii = 0; ii < skaitluMasivs2.Length; ii++)
            {
                int skaitlisNoMasiva2 = skaitluMasivs2[ii];
                Console.WriteLine(skaitlisNoMasiva2);
            }


            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                //paņem skaitli no masīva, kurš atrodas pozīcijā 'i
                int? skaitlisNoMasiva = skaitluMasivs[i];

                if (skaitlisNoMasiva.HasValue)
                {
                    Console.WriteLine(skaitlisNoMasiva);
                }
                else
                {
                    Console.WriteLine("Nav Vērtības");

                }


            }

        }
        public static void Piemers2()
        {
            List<int> skaitluSaraksts = new List<int>();
            //saraksts ir dinamisks masīvs - var pievieno elementus un izdzēst

            skaitluSaraksts.Add(5);
            skaitluSaraksts.Add(7);
            skaitluSaraksts.Add(20);

            List<int> skaitluSaraksts2 = new List<int>()
            {
                5,7,20
            };
            skaitluSaraksts2.Add(100);
            skaitluSaraksts2.AddRange(new[] { 45, 200, 34 });
            skaitluSaraksts2 = skaitluSaraksts2
                .Where(s => s != 100) //visas izņemot 100
                .OrderBy(s => s) // sakārto augošā secībā
                .ToList(); //pārvērš atpakaļ sarakstu

            // saīsināts cikla for pieraksts
            //kas iet cauri visiem saraksta/masīva elemetiem
            foreach(int skaitlis in skaitluSaraksts2)
            {
                Console.WriteLine(skaitlis);
            }
        }
    }
}
