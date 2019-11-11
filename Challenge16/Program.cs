using System;

namespace FruitFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };

            // Find the index of a fruit
            IndexFinder(fruits, "Jeruk"); // Output: 0
            IndexFinder(fruits, "Pepaya"); // Output: 3
            IndexFinder(fruits, "Markisa"); // Output: 6
        }

        static int IndexFinder(string[] list, string value)
        {
            return 0;
        }
    }
}
