using System;
using System.Collections.Generic;

namespace BlackJack.Classes
{
    public class Player
    {
        public List<Card> Cards; //pasakam, ka būs mainīgais - kāršu saraksts

        public Player()
        {
            Cards = new List<Card>(); //izveido jaunu tukšu sarakstu
        }
        public void GiveCard(Card card)
        {
            Console.WriteLine("Spēlētājs saņēma kārti " + card.Suit + card.Value);

            Cards.Add(card);
        }
        public int CountPoints()
        {
            int points = 0;
            int aceCount = 0;

            foreach(var c in Cards) // var - sameklē tipu augstāk, vai no vērtības nolasa
            {
                points += c.GetValue();
                if(c.Value == "A")
                {
                    aceCount++;
                }

            }
            while(points>21&& aceCount >0)
            {
                points -= 10;
                aceCount--;
            }

            return points;


        }

        public bool NeedAnotherCard()
        {
            var answer = Game.GetAnswer("Vai nepieciešana kārts");

            return answer;
        }
    }
}
