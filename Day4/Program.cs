using System;

namespace Day4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Atrums atrums = new Atrums();
             atrums.AtrumsIR();

             Piemeri();

         }
         public static void Piemeri()
         {
             // i++ jeb i=i+1
             for (int i = 40; i <= 50; i=i+2)
             {
                 Console.WriteLine("i = " + i);
             }

             int n = 10;
             //pildīt tik ilgi, kamēr n ir lielāks vai vienāds ar 0
             while(n>=0)
             {
                 Console.WriteLine("n = " + n);
                 n = n - 3;
             }
             bool turpinat = true;
             while(turpinat)
             {
                 Console.Write("Ievadi skaitli: ");

                 int skaitlis = Convert.ToInt32(Console.ReadLine());

                 Console.Write("Vai turpināt ievadi (j/n)? ");
                 string atbilde = Console.ReadLine();
                 if(atbilde == "j")
                 {
                     turpinat = true;
                 }
                 else
                 {
                     turpinat = false;
                 }*/
            Cikli cikli = new Cikli();
            cikli.Rezgis();
            cikli.Gadi();
            cikli.SkaitsN();


            Console.ReadLine();
                
        }
    }
}
