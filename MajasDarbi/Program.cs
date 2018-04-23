using System;

namespace MajasDarbi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Uzdevumi uzd1 = new Uzdevumi();
            uzd1.Rombs();
            uzd1.Pilngadiba();
            uzd1.VidejaVertiba();
            uzd1.MervienibuMaina();
            uzd1.IntervalaParbaude();


            Console.ReadLine();

        }
    }
}
