using System;
namespace BlackJack.Classes
{
    public class Card
    {
        //vērtība
        public string Value;
        //masts
        public char Suit;

        /// <summary>
        /// izveido jaunu kārt
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="suit">Suit.</param>
        public Card(string value, char suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        /// <summary>
        /// kārts skaitliskā vērtība
        /// </summary>
        /// <returns>The value.</returns>
        public int GetValue()
        {
            return 0;
        }

    }
}
