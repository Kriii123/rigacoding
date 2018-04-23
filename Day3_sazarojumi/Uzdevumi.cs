using System;
namespace Day3_sazarojumi
{
    public class Uzdevumi
    {
        public void VienadiSkaitli()
        {
            Console.Write("Ievadi pirmo skaitli ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi otro skaitli ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            if(skaitlis1 == skaitlis2)
            {
                Console.WriteLine("Skaitļi ir vienādi");
            }
            else
                
            {
                Console.WriteLine("Skaitļi nav vienādi");  
            }
        }
        public void Menesi()
        {
            Console.Write("Ievadi mēneša nosaukumu: ");
            string menesis = Console.ReadLine();

            if (menesis == "Februāris")
            {
                Console.WriteLine("Dienu skaits ir 28");
            }
            else if (menesis == "Aprīlis" || menesis == "Jūnijs" || menesis == "Septembris" || menesis == "Novembris")
            {
                Console.WriteLine("Dienu skaits ir 30");
            }
            else
            {
                Console.WriteLine("Dienu skaits ir 31");
            }
        }
    }
}
