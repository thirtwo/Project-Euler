using System;

namespace Project_Euler
{
    class Multiplesof3or5
    {
       
        public static void Find()
        {
            Console.WriteLine(FindSumOf3Or5Multiples(1000));
        }

        private static int FindSumOf3Or5Multiples(int max)
        {
            var sum = 0;
            for (int i = 1; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i; 
            }
            return sum;
        }
    }
}
