using System;

namespace Challenge
{
    public class SumArgs
    {
        static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
            // int ret = sum(args);

            // Console.Write("total sum : {0}", ret);
        }

        public static int sum(int[] num)
        {
            int ret = 0;
            foreach(int i in num){
                ret += i;
            }

            return ret;
        }
    }
}
