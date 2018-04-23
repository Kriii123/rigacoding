using System;

namespace Day3_sazarojumi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Uzdevumi uzd = new Uzdevumi();
            /*uzd.VienadiSkaitli();*/
            uzd.Menesi();

            Console.ReadLine();



        }
        public void Piemers()
        {
            int skaitlis = 5;

            //pārbaudes rezultāts - vai skaitlis ir vienāds ar 5
            bool vaiIrVienādsArPieci = skaitlis == 5;

            if (skaitlis > 5)
            {
                Console.WriteLine("Skaitlis ir lielāks par 5");
            }
            else if (vaiIrVienādsArPieci)
            {
                Console.WriteLine("Skaitlis ir vienāds ar 5");
            }
            else
            {
                Console.WriteLine("Skaitlis ir mazāks par 5");
            }       
        }
    }
}
