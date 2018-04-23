using System;

namespace Day2
{
    class MainClass
    {
        /// <summary>
        /// Galvenais ieejas punksts aplikācijā
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            //izveido jaunu objektu no klases "Uzdevumi"
            Uzdevumi uzdevumi = new Uzdevumi();

            //izsauc objekta funkcijas
            /*uzdevumi.Starpiba(23, 11);
            uzdevumi.Reizinajums(3444, 562, 32);
            uzdevumi.Maina(5, 6);
            uzdevumi.Darbibas(5, 2);
            uzdevumi.IevadiVardu();
            uzdevumi.Celsijs();*/

            /*Auto auto = new Auto();
            auto.Krasa = "Melns";
            auto.Marka = "Audi";
            auto.Info();

            Auto vw = new Auto();
            vw.Krasa = "zaļš";
            vw.Marka = "VW";
            vw.Info();

            Auto nezinams = new Auto();
            nezinams.Info();*/

            Kvadrats kv1 = new Kvadrats();
            kv1.Krasa = "sarkans";
            kv1.MalasGarums = 5;
            kv1.KrasasIzvade();
            //laukums
            int laukums = kv1.Laukums();
            Console.WriteLine("Laukums ir " + laukums);
            //perimetrs
            Console.WriteLine("Perimetrs ir " + kv1.Perimetrs());

            Kvadrats kv2 = new Kvadrats("melns", 6);
            kv2.KrasasIzvade();
            Console.WriteLine("Perimetrs ir " + kv2.Perimetrs());

            //funkcija, kas patur atvērtu logu
            //līdz mēs nospiežam ENTER
            Console.ReadLine();
        }
    }
}
