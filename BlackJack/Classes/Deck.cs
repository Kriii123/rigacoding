using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack.Classes
{
    public class Deck
    {
        public char[] Suits = { 'H', 'D', 'S', 'C' };
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        /// <summary>
        /// Saraksts ar kārtīm
        /// </summary>
        public List <Card> Cards; // ievadei izmanto ciklu ciklā (for)

        public Deck()
        {
            Cards = new List<Card>[52];

            foreach(char s in Suits)
            {
                foreach(string v in Values)
                {
                    //pievieno jaunu kārti
                    Cards.Add(new Card(v, s));

                }
            }
        }

        public Card TakeCard()
        {
            Card newCard = Cards[0];
            Cards.RemoveAt(0);

            return newCard;

        }
        /// <summary>
        /// Izveido jaunu kārti
        /// </summary>
        /// <returns>The new card.</returns>
        public Deck TakeNewCard()
        {
            return null;
        }
        /// <summary>
        /// Sajauc kāršu kavu
        /// </summary>
        public void Shuffle()
        {
            
        }
    }
}
