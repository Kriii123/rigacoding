using System;

namespace day1
{
    /// <summary>
    /// mana pirmā klase - komentāri redzami tikai izstrādātājiem
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            //teksta izvade konsolē - dubultās pēdiņas
            Console.WriteLine("Hello World!");
            //skaitļa izvade
            Console.WriteLine(5);
            //decimālskaitļiem kā attdalītāju izmanto punktu
            Console.WriteLine(4.6);
            //viena simbola izvadei mazās pēdiņas, vairākus simbolus nevar izvadīt
            Console.WriteLine('T');

            int skaitlis1 = 9223;
            Console.WriteLine(skaitlis1);
            //vispirms jāizveido mainīgie un tad var veidot konsoli
            //konsole meklēs mainīgos, ja iekavās ir bez pēdiņām

            Console.WriteLine("Es mācos! Viss skaidrs");

            int number = 221;

            Console.WriteLine(number);

            SayHello();

            //lai izsauktu jaunu funkciju, iepriekšējā funkcijā jāievieto izsaukums

            Console.ReadLine();
            /*
             komentāri 
             vairākās 
             rindās
             */
        }
        //funkcija bez rezultāta - void
        public static void SayHello()
        {
            Console.WriteLine("Hello");
            Numbers();
        }
        public static void Numbers()
        //funkciju nevajag izsaukt tajā pašā funkcijā, tad tā atkārtosies
        //
        {
            Console.WriteLine("sanāca");
            //SayHello(); - izsauc funkcijas atkārtoti
        }
    }
}