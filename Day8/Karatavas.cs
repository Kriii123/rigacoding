using System;
namespace Day8
{
    public class Karatavas
    {
        string[] words;

        string word;

        char[] guessedWord;

        public Karatavas()
        {
            words = new string[]
            {
                "ZEMENE",
                "LIDMAŠĪNA",
                "SAULRIETS",
                "VARDE"
            };
        }
        public void JaunaSpele()
        {
            Console.WriteLine("Sākam jaunu spēli!");

            string NewWord = words[new Random().Next(0, words.Length)];

            int count = NewWord.Length;
            guessedWord = new char[count];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
                Console.Write(guessedWord[i]);

            }

            int lives = count;
            bool won = false;
            while (!won && lives > 0)
            {
                Console.Write(Environment.NewLine + "ievadi burtu: ");
                char burts = Console.ReadLine()[0];
                bool correctGuess = false;
                for (int i = 0; i < NewWord.Length; i++)
                {
                    char burts2 = NewWord[i];
                    correctGuess = burts == burts2;
                    if (correctGuess == true)
                    {
                        guessedWord[i] = burts;
                    }

                }

                foreach (char guessed in guessedWord)
                {
                    Console.Write(guessed);

                }
                foreach (char line in guessedWord)

            }

        }
    }
}
