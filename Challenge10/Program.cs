﻿using System;

namespace Challenge
{
    public class Calculator
    {

        public static int Sum(int a, int b){
            return a + b;
        }


        public static int Substract(int a, int b){
            return a - b;
        }


        public static int Multiply(int a, int b){
            return a * b;
        }


        public static int Divide(int a, int b){
            return a / b;
        }


        static void Main(string[] args)
        {
            // Create methods called Sum, Substract, Multiply, Divide
            // Each methods should accept two parameters number
            // and also return a number.
            // Example:
            // Sum(1, 6) // Output: 7
            int a = 5;
            int b = 5;

            Console.WriteLine("Sum       : {0}", Sum(a, b));
            Console.WriteLine("Substract : {0}", Substract(a, b));
            Console.WriteLine("Multiply  : {0}", Multiply(a, b));
            Console.WriteLine("Divide    : {0}", Divide(a, b));
        }
    }
}
