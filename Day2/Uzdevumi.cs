using System;
namespace Day2
{
    public class Uzdevumi
    {
      /// <summary>
      /// Starpiba starp skaitlis1 and skaitlis2.
      /// </summary>
      /// <returns>The starpiba.</returns>
      /// <param name="skaitlis1">Skaitlis1.</param>
      /// <param name="skaitlis2">Skaitlis2.</param>
        public void Starpiba(int skaitlis1, int skaitlis2)
        {
            int starpiba = skaitlis1 - skaitlis2;
            Console.WriteLine(starpiba);

        }
        public void Reizinajums(int skaitlis1, int skaitlis2, int skaitlis3)
        {
            long reizinajums = skaitlis1 * skaitlis2 * skaitlis3;
            Console.WriteLine(reizinajums);
        }
        public void Maina(int skaitlis1, int skaitlis2)
        {
            Console.WriteLine("skaitlis1 = " + skaitlis1);
            Console.WriteLine("skaitlis2 = " + skaitlis2);

            //vajag izveidot 3. mainīgo kurš ir kāda objekta sākotnējā vērtība.
            int skaitlis1VecaVertiba = skaitlis1;
            skaitlis1 = skaitlis2;
            skaitlis2 = skaitlis1VecaVertiba;

            Console.WriteLine("skaitlis1 = " + skaitlis1);
            Console.WriteLine("skaitlis2 = " + skaitlis2);
        }
        public void Darbibas(int sk1, int sk2)
        {
            int summa = sk1 + sk2;
            Console.WriteLine("Summa ir " + summa);

            int starpiba = sk1 - sk2;
            Console.WriteLine("Starpība ir " + starpiba);

            int reizinajums = sk1 * sk2;
            Console.WriteLine("Reizinājums ir " + reizinajums);

            // lai būtu decimālskaitlis, pie viena skaitļa jāpieliek double
            Console.WriteLine("Dalījums ir " + (double)sk1 / sk2);

            // procentu zīmē ir priekš dalījuma atlikuma
            Console.WriteLine(sk1 % sk2);
       
        }

        //definējam jaunu funkciju, kas nesaņem parametrus un neatgriež vērtību
        public void IevadiVardu()
        {
            //izvada tekstu un kursors paliek tajā pašā rindiņā
            Console.Write("Ievadi vārdu: ");
            //nolasa ievadīto tekstu
            string vards = Console.ReadLine();

            //izvada tekstu un kursors pāriet jaunā rindā
            Console.WriteLine("Tevi sauc " + vards);

            Console.Write("Ievadi skaitli ");
            //pārveido ievadīto tekstu uz veselu skaitli
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            //izvada rezultātu
            Console.WriteLine("Skaitlis ir " + skaitlis);

        }
        public void Celsijs()
        {
            Console.Write("Ievadi grādus pēc Celsija: ");
            int temperatura = Convert.ToInt32(Console.ReadLine());

            double gradiF = temperatura * 9 / 5 + 32;
            int gradiK = temperatura + 273;

            Console.WriteLine("temperatūra pēc Fārenheita ir " + gradiF);
            Console.WriteLine("temperatūra pēc Kelvina ir " + gradiK);

        }
    }
}
