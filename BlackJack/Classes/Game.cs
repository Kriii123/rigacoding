using System;
namespace BlackJack.Classes
{
    public class Game
    {
        public Dealer Dealer; //objekti
        public Player Player;
        public Deck Deck;

        public bool StartNewGame()
        {
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli?");

            if(startNew) // ja izpildās
            {
                Console.WriteLine("Uzsākta jauna spēle!");
                Deck = new Deck();
                Dealer = new Dealer();
                Player = new Player();

            }

            return startNew;

        }
        public static bool GetAnswer(string question)// varu izsaukt jebkurā klasē, jo ir publiska.
        {
            Console.Write(question + " (jā/nē)? ");
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "jā"; //vai izpildās?

            return answer;
        }
    }
}
