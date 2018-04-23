using System;
namespace Day6
{
    public class Cikli2
    {


        public static void Trissturis()
        // static - nevar piekļūt objekta funkcijām, tikai tad, kad ir tā palī
        {
            Console.Write("Ievadi skaitli: ");
            int rindas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rindas; i++)
            {
                //izvada skaitļus no viens līdz rindas kārtas numuram
                //for (int ii = 1; ii <= i; ii++)
                    for (int ii = rindas - i+1; ii >= 1; ii--)
                {
                    Console.Write(ii);

                }
                Console.WriteLine();

            }
        }
    }
}
