using System;
namespace BlackJack.Classes
{
    public class Game
    {
        public Dealer Dealer; //objekti - mainīgie, kas tiks izmantoti klases ietvaros - tās būs īpašības
        public Player Player;
        public Deck Deck;

        public bool StartNewGame()
        {
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli? ");

            if (startNew) // ja izpildās
            {
                Console.WriteLine("Uzsākta jauna spēle!");
                Deck = Deck.TakeNewDeck(); // veido jaunu konstruktoru un uzsauc to
                Dealer = new Dealer();
                Player = new Player();

                Deck.Shuffle();//iet uz deku un izsauc to funkciju

                Player.GiveCard(Deck.TakeCard());
                Player.GiveCard(Deck.TakeCard());

                while(Player.NeedAnotherCard())
                {
                    Player.GiveCard(Deck.TakeCard());
                }

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
