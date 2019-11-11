using System;

namespace FindMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            Console.WriteLine(FindMax(numbers)); // Output: 330
            Console.WriteLine(FindMin(numbers)); // Output: -65
            Console.WriteLine(FindAverage(numbers)); // Output: 52.16
        }

        static int FindMax(int[] numbers)
        {
            int ln = numbers.Length;
            int max = 0;
			int temp = 0;
            for(int i=0; i<ln; i++){
                temp = numbers[i];
				if(temp > max){
					max = temp;
				}
            }
			
            return max;
        }

        static int FindMin(int[] numbers)
        {
			int ln = numbers.Length;
            int min = 0;
			int temp = 0;
            for(int i=0; i<ln; i++){
                temp = numbers[i];
				if(temp < min){
					min = temp;
				}
            }
            return min;
        }

        static double FindAverage(int[] numbers)
        {
			int ln = numbers.Length;
			double avg = 0;
			foreach(int i in numbers)
				avg += i;
			
			return avg/ln;
        }
    }
}
