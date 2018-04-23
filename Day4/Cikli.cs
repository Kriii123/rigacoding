using System;
namespace Day4
{
    public class Cikli
    {
        // for cikls
        // sākotnējā vērtība, izpildīt līdz konkrētai vērtībai, palielinās par vērtību
        //tukšs for cikls ir bez vērtībām un atkārtojas mūžīgi. ciklu var pārtraukt ar Brake
        // for ciklu izmanto, kad ir zināms skaits

        //while cikls - nepieciešams nosacījums. pildās tik ilgi, kamēr nosacījums ir patiess. pārbaudi veic pirms izpildes
        //var izmantot arī skaitīšanai
        // bezgalīgs cikls ar While - while (true)
        //paveids do while - pārbaudi veic pēc izpildes

        public void Gadi()
        {
            Console.Write("Ievadi dzimšanas gadu: ");
            int gads = Convert.ToInt32(Console.ReadLine());
            //
            for (int gadi = gads; gadi <= DateTime.Now.Year; gadi++)
            {
                Console.WriteLine("gads ir " + gadi);
            }
        }

        public void SkaitsN()
        {
            Console.Write("Ievadi skaitu: ");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int summa = 0;
            for (int i = 1; i <= skaits; i++)
                
            {
                Console.Write("Ieraksti " + i + ". skaitli: ");

                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa = summa + skaitlis;
                // summa += skaitlis
            }
            Console.WriteLine("Summa ir " + summa);
            Console.WriteLine("Vidējā vērtība ir " + summa / skaits);


        }
        public void Rezgis()
        {
            Console.Write("Ievadi skaitu: ");
            int skaits = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= skaits; i++)
            {

                for (int kolonna = 1; kolonna <= skaits; kolonna++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                //izvadam simbolu skaitu un pārejam jaunā rindā 
            }
        }
    }
}
