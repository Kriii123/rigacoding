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

        public Deck() // funkcija - iekavas, nav semikols, šai nav tipa un nav arī void, sakrīt ar klases nosaukumu
        {
            Cards = new List<Card>();

            foreach(char s in Suits)
            {
                foreach(string v in Values)
                {
                    //pievieno jaunu kārti
                    Cards.Add(new Card(v, s));//uztaisa sarakstu ar visām vērtībām

                }
            }
        }

        public Card TakeCard()
        {
            Card newCard = Cards[0];//jauns mainīgais - kārts - paņem pirmo kārti no kavas
            Cards.RemoveAt(0); // to pašu elemetu izdzēš no kavas

            return newCard; //tā kārts ko izdzēsām

        }
        /// <summary>
        /// Izveido jaunu kārti
        /// </summary>
        /// <returns>The new card.</returns>
        public static Deck TakeNewDeck()
        {
            return new Deck();
        }
        /// <summary>
        /// Sajauc kāršu kavu
        /// </summary>
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();//giud - globālais unikālais identifikators

        }
    }
}
