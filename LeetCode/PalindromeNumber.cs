using System.Collections;

namespace LeetCode
{
    // Given an integer x, return true if x is palindrome integer.
    // An integer is a palindrome when it reads the same backward as forward. 
    // For example, 121 is palindrome while 123 is not.

    public class PalindromeNumber
    {
        public bool Calculate(int x)
        {
            string xString = $"{x}";
            int i = 0;

            while (i < xString.Length - i - 1)
            {
                if (xString[i] != xString[xString.Length - i - 1]) return false;
                i++;
            }


            return true;
        }
    }
}