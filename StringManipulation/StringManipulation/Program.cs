using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, \nand the universe trying to build bigger and better idiots. So far, the universe is winning.";
            string word, answer;

            Console.WriteLine(sentence);
            Console.WriteLine("\nWhat word would you like to look for in the sentence above?");
            word = Console.ReadLine().ToLower();
            Console.WriteLine("What word would you like to change for the sentence above?");
            answer = Console.ReadLine().ToLower();

            if (sentence.Contains(word))
            {
                for (int i = 0; i < sentence.Length; --i)
                {
                  
                }
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word: {word}.");
            }
        }
    }
}
