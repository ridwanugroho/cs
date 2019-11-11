using System;

namespace DaysToNextBirthday
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Your next birthday date, please! ");
            string date = Console.ReadLine();
            
            var today = DateTime.Now;
            DateTime birthDate = DateTime.Parse(date);
            TimeSpan gap =  birthDate - today;
            Console.WriteLine("{0} days remaining to my next birthday.", gap.Days);
        }
    }
}
