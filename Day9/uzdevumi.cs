using System;
namespace Day9
{
    public class uzdevumi
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

        }
    }
}
