using System;

namespace Project_Euler
{
    class EvenFibonacciNumbers
    {
        public static void Find()
        {
            Console.WriteLine(FindSumOfEvenFibonacciNumbers(4000000));
        }

        static ulong FindSumOfEvenFibonacciNumbers(int max)
        {
            ulong sum = 0;
            int lastFibonacci = 0, i = 1;
            while (i < max)
            {
                var val = Convert.ToUInt64(i + lastFibonacci);
                if (val % 2 == 0)
                    sum += val;
                var temp = i;
                i += lastFibonacci;
                lastFibonacci = temp;
            }
            return sum;
        }
    }
}
