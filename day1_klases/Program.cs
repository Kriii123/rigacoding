using System;

namespace day1_klases
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1. mainīgā tips = Mana pirmā klase
            // 2. mainīgā nosaukums = objekts
            // 3. sākotnējā vērtība = jauns objekts no klases
            /*ManaPirmaKlase objekts = new ManaPirmaKlase();
            objekts.SayHello();
            //punkts nozīmē - izsaukt objekta funkciju
            objekts.SayHello();
            ManaPirmaKlase2 objekts2 = new ManaPirmaKlase2();
            objekts2.sveiks();

            //lai izsauktu funkciju, jāuztaisa mainīgais un tad jāizsauc šis mainīgais
            int rezultats = objekts.GetNumber();

            Console.WriteLine(rezultats);

            // mainīgie nevar būt vienādi, bet mainīgais bez definēšanas var aizstāt iepriekšejo vērtību
            int rezultats2 = objekts.GetNumber2(100);


            Console.WriteLine(rezultats2);
            rezultats = objekts.GetNumber2(200);
            Console.WriteLine(rezultats);*/

            Uzdevums uzdevumi = new Uzdevums();
            uzdevumi.Uzdevums1("Krišjānis");
            uzdevumi.Uzdevums2(23, 22);

            Console.ReadLine();
        }
    }
}
