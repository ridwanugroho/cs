﻿using System;

namespace LeapYear
{
    class Program
    {

        static private bool IsLeapYear(int args){
            return DateTime.IsLeapYear(args);
        }

        static void Main(string[] args)
        {
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
            Console.Write("insert year : ");
            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine(IsLeapYear(inp));
        }
    }
}
