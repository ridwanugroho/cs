using System;

namespace SumArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
            int ret = 0;
            foreach(String i in args){
                ret += int.Parse(i);
            }

            Console.Write("total sum : {0}", ret);
        }
    }
}
