using System;

namespace Project_Euler
{
    class LargestPalindromeProduct
    {
        public static void Find()
        {
            Console.WriteLine(MaxPalindrome(3));
        }
        private static int MaxPalindrome(int digit)
        {
            int palindrome = 0;
            var maxVal = CreateMaxNumber(digit);
            var number1 = maxVal;
            var number2 = maxVal;
            for (int h = maxVal; h > 0; h--)
            {
                for (int i = number2; i > 0; i--)
                {
                    var val = number1 * number2;
                    if (val < palindrome) break;
                    if (IsPalindrome(val.ToString()))
                    {
                        if (val > palindrome)
                            palindrome = val;
                        break;
                    }
                    number1--;
                }
                number2--;
                number1 = maxVal;
            }
            return palindrome;
        }
        private static int CreateMaxNumber(int digit)
        {
            var val = 0;
            for (int i = 0; i < digit; i++)
            {
                val += (int)Math.Pow(10, i) * 9;
            }
            return val;
        }
        private static bool IsPalindrome(string number)
        {
            var digit = number.ToString().Length;
            for (int i = 0; i < digit; i++)
            {
                if(number[i] != number[^(i+1)]) 
                    return false;
            }
            return true;
        }
    }
}
