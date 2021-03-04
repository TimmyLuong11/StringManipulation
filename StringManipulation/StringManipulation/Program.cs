using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defined Variables and the sentence for the program
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            string word, answer, revWord = "";

            //Outputting the sentences to the user and asking the user what word to look for and what word to change
            Console.WriteLine(sentence);
            Console.WriteLine("\nWhat word would you like to look for in the sentence above?");
            word = Console.ReadLine().ToLower();
            Console.WriteLine("What word would you like to change for the sentence above?");
            answer = Console.ReadLine().ToLower();

            //Test to see if the sentence contain the word
            //If the sentence does contain the word it will repalce it 
            //If the sentence does not contain the word it will reverse it
            if (sentence.Contains(word))
            {
                Console.WriteLine($"\n{sentence.Replace(word, answer)}");
            }
            else
            {
                Console.WriteLine($"\nSorry, I could not find your word: {word}.");
                for (int i = word.Length-1; i >= 0; --i)
                {
                    revWord += word[i];
                }
                Console.WriteLine(revWord);
            }
        }
    }
}
