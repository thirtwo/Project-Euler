using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class LargestPrimeFactor
    {
        private static List<long> primeNumbers = new List<long>();
        private static List<long> dividerPrimeNumbers = new List<long>();
        public static void Find()
        {
            Console.WriteLine(FindLargestDividerPrime(600851475143));
        }
        private static long FindLargestDividerPrime(long number)
        {
            GetPrimeNumbers(number);
            return dividerPrimeNumbers[^1];
        }
        private static  void GetPrimeNumbers(long number)
        {
            long max = number;
            for (long i = 2; i <= number; i++)
            {
                if (i >= max) break;
                int divideCount = 1;
                if (primeNumbers.Count > 0)
                {
                    if (DividedByPrime(i))
                    {
                        continue;
                    }
                }
                for (long k = primeNumbers.Count > 0 ? primeNumbers[^1] : 1; k < i; k++)
                {
                    if (i % k == 0)
                        divideCount++;
                    if (divideCount > 1)
                        break;
                }
                if (divideCount <= 2)
                {
                    primeNumbers.Add(i);
                    FindDividerPrimeNumbers(number, i);
                    max = number / i;
                }
            }
        }

        private static void FindDividerPrimeNumbers(long number, long i)
        {
            if (number % i == 0)
            {
                dividerPrimeNumbers.Add(i);
            }
        }

        private static bool DividedByPrime(long i)
        {
            for (int k = 0; k < primeNumbers.Count; k++)
            {
                if (i % primeNumbers[k] == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
