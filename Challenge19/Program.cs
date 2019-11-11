using System;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] points = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            Array.Sort(points);
			foreach(int i in points)
				Console.Write("{0}  ", i);
        }
    }
}
