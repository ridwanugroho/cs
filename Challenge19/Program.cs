using System;

namespace Challenge
{
    public class Sorter
    {
        static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] points = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            var ret = sort(points);
			foreach(int i in ret)
				Console.Write("{0}  ", i);
        }

        public static int[] sort(int[] num)
        {
            Array.Sort(num);
            return num;
        }
    }
}
