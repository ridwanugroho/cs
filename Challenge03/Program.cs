using System;

namespace Challenge
{
    public class StrLength
    {
        
        private static int countString(string args){
            return args.Length;
        }

        static void Main(string[] args)
        {
            // Create new method called "CountString".
            // That method should accept a string and will
            // return length of characters input.

            Console.WriteLine("'Hello World!' have {0} characters", countString("Hello World!"));
            Console.WriteLine("'Hello Universe!' have {0} characters", countString("Hello Universe!"));
        }

    }
}
