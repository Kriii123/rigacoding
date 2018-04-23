using System;
namespace Day2
{
    public class Auto
    {
        /// <summary>
        /// konstruktors
        /// * nav rezultāta tipa
        /// * nosaukums sakrīt ar klases nosaukumu
        /// </summary>
        public Auto()
        {
            this.Marka = "Nezināms";
            this.Krasa = "Nezināms";
        }
        /// <summary>
        /// Auto marka
        /// </summary>
        public string Marka;

        /// <summary>
        /// Auto krāsa
        /// </summary>
        public string Krasa;

        public void Info()
        {
            Console.WriteLine("Auto marka ir " + this.Marka);

            Console.WriteLine("Auto krāsa ir " + Krasa);
        }
    }
}
