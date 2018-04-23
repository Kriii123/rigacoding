using System;
namespace Day2
{
    public class Kvadrats
    {
        public string Krasa;
        public int MalasGarums;

        public Kvadrats()
        {
            
        }

        public Kvadrats (string krasa, int garums)
        {
            this.Krasa = krasa;
            this.MalasGarums = garums;
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa ir " + this.Krasa);

        }
        public int Laukums()
        {
            return this.MalasGarums * this.MalasGarums;
        }

        public int Perimetrs()
        {
            return MalasGarums * 4;
        }
    }
}
