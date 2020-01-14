using System;

namespace Challenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input your name : ");
            String name = Console.ReadLine();
            string name1 = nama(name);
            Console.WriteLine("Hello, my name is {0}.", name);
        }
        
        public static string nama(string str)
        {
            return str;
        }
    }
}
