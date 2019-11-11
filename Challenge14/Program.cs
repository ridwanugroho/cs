using System;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            IsPalindrome("ipsum"); // false
            IsPalindrome("malam"); // true
            IsPalindrome("tidur"); // false
            IsPalindrome("kasur rusak"); // true
            IsPalindrome("ibu ratna antar ubi"); // true
        }

        static bool IsPalindrome(string text)
        {
            return true;
        }
    }
}
