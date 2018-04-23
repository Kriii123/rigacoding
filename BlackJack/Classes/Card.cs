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
            switch(Value)
            {
                case "A":
                    return 11;
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:
                    return Convert.ToInt32(Value); //atgriež skaitļus, kas jau ir skaitlis.
                    
            }
        }

    }
}
