using System;

namespace Challenge
{
    public class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countWords("Hello")); // Output: 1
            Console.WriteLine(countWords("Hello World")); // Output: 2
            Console.WriteLine(countWords("Lorem ipsum dolor sit amet")); // Output: 5
        }

        public static int countWords(string value)
        {
            // Make this method to be able counting words

            return value.Split(' ').Length;
        }
    }
}
