using System;
using BlackJack.Classes;

namespace BlackJack
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Game game = new Game();

            while(true)
            {
                if(!game.StartNewGame())
                {
                    break;
                }

            }

            Console.WriteLine("Spēle pabeigta! ");


            Console.ReadLine();

        }
    }
}
