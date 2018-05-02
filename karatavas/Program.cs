using System;

namespace karatavas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Karatavas karatavas = new Karatavas(); //izveido jaunu objektu - konstruktoru
            karatavas.JaunaSpele();

            Console.WriteLine(karatavas.AtminetaisVards());

            while(!karatavas.VaiIrAtminets())
            {
                Console.Write("Ievadi burtu: ");
                char burts = Console.ReadLine()[0];

                if(karatavas.Minet(burts))
                {
                    Console.WriteLine(karatavas.AtminetaisVards());
                }
                else
                {
                    Console.WriteLine("Burts nav šajā vārdā!");

                }
            }

            Console.WriteLine("Vārds ir atminēts!");

        }
    }
}
