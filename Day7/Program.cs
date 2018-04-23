using System;

namespace Day7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            uzdevumi.HighLow();
            uzdevumi.Result();
            uzdevumi.Galvaspilseta();
            Piemers();
            uzdevumi.SkaitlisPieci();

            Console.ReadLine();
        }
        public static void Piemers()
        {
            Console.Write("ievadi dienu: ");
            string diena = Console.ReadLine();
            switch(diena)//pārbaudīsim starp vairākiem mainīgajiem
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "Pk":
                    Console.WriteLine("Ir darbadiena. ");
                    if(diena == "Pk")
                    {
                        Console.WriteLine("Piektdiena!");
                    }
                    break;
                case "S":
                case "Sv":
                    Console.WriteLine("Ir brīvdiena. ");
                    break;
                default://ja neatbilst keisam.
                    Console.WriteLine("Nezināma diena. ");
                    break;

            }
        }
    }
}
