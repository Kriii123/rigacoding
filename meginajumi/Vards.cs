using System;
namespace meginajumi
{
    public class Vards
    {
        public void IevadiVardu()
        {
            Console.Write("Ievadi vārdu ");
            string vards = Console.ReadLine();
            Console.WriteLine("Tevi sauc " + vards);
            Console.Write("Ievadi savu vecumu ");
            int vecums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tev ir " + vecums + " gadi");
      
    }
}

