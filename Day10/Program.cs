using System;

namespace Day10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //N=3
            //i=1; atst=2=3-1; zv=1=2*1-1
            //i=2; atst=1=3-2; zv=3=2*2-1
            //i=3; atst=0=3-3; zv=5=2*3-1
            int N = 10;
            for (int i = 1; i <= N;i++)
            {
                for (int atst = 1; atst <= N - i; atst++)
                {
                    Console.Write(" "); 
                }
                for (int zv = 1; zv <= 2*i-1;zv++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = N-1 ; i >= 1; i--)
            {
                for (int atst = 1; atst <= N - i; atst++)
                {
                    Console.Write(" ");
                }
                for (int zv = 1; zv <= 2 * i - 1; zv++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
