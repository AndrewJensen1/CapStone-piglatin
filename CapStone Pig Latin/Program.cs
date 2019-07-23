using System;
using System.Text.RegularExpressions;

namespace CapStone_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator");

            bool input = true;
            while (input)
            {
                Console.WriteLine("\nPlease enter a line to be translated");
                string userInput = Console.ReadLine();
                if (Regex.IsMatch(userInput, @"^[a-zA-Z]+$"))
                {


                    Console.WriteLine(convertWordToPigLatin(userInput.ToLower()));


                    Console.WriteLine("\nWould you like to translate something else? y/n");
                    string userInput2 = Console.ReadLine();

                    if (userInput2 == "y")
                    {
                        input = true;
                    }
                    else
                    {
                        Console.WriteLine("\nGood Bye");
                        input = false;
                    }
                }
            }
                
        }

        public static string convertWordToPigLatin(string input)
        {
            char[] vowelArray = { 'a', 'e', 'i', 'o','u' };

            foreach (char character in vowelArray)
            {
                if (input[0].Equals(character))
                {
                    return input + "way";
                }

            }
            int vowelLocation = input.IndexOfAny(vowelArray);
            string wordPart1 = input.Substring(0, vowelLocation);
            string wordPart2 = input.Substring(vowelLocation, input.Length - 1);
            string convertedWord = wordPart2 + wordPart1 + "ay";
            return convertedWord;
        }
        
    }
}
