using System;

namespace FooBarBaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a loop from 1 to 1000.
            // Each loop should print out a number.
            // But, there is some criteria:
            // 1) When the number multiplied by 5, the output will change like so "5. Foo".
            // 2) When the number multiplied by 20, the output will change like so "40. Bar".
            // 3) When the number multiplied by 100, the output will change like so "300. Baz".
            for(int i=0; i<1000; i++){
                if(i%5 == 0){
                    if(i%20 == 0){
                        if(i%100 == 0){
                            Console.WriteLine("{0}. Baz", i);
                        }

                        else
                            Console.WriteLine("{0}. Bar", i);
                    }

                    else
                        Console.WriteLine("{0}. Foo", i);
                }

                else
                    Console.WriteLine("{0}.", i);
            }
        }
    }
}
