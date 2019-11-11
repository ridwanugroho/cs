using System;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to convert temprature unit
            Console.WriteLine(CelciusToFahrenheit(0)); // Output: 32
            Console.WriteLine(FahrenheitToCelcius(50)); // Output: 10
            Console.WriteLine(CelciusToKelvin(100)); // Output: 373.15
            Console.WriteLine(KelvinToCelcius(375)); // Output: 101.85
            Console.WriteLine(KelvinToFahrenheit(375)); // Output: 215.33
            Console.WriteLine(FahrenheitToKelvin(12)); // Output: 262.039

        }

        private static double CelciusToFahrenheit(double value)
        {
            return Math.Round((value * 9/5) + 32, 2);
        }

        private static double FahrenheitToCelcius(double value)
        {
            return Math.Round((value - 32) * 5/9, 2);
        }

        private static double CelciusToKelvin(double value)
        {
            return Math.Round(value + 273.15, 2);
        }

        private static double KelvinToCelcius(double value)
        {
            return Math.Round(value - 273.15, 2);
        }

        private static double KelvinToFahrenheit(double value)
        {
            return Math.Round((value - 273.15) * 9/5 + 32, 2);
        }

        private static double FahrenheitToKelvin(double value)
        {
            return Math.Round((value - 32) * 5/9 + 273.15, 3);
        }
    }
}
