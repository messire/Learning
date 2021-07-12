using System;
using System.ComponentModel.Design;
using System.Text;

namespace LongestPalindrome
{
    // Given a string s, return the longest palindromic substring in s.
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = "bb";
            string result = LongestPalindrome(s);
            // Output: bb
            Console.WriteLine(result);

            s = "ccc";
            result = LongestPalindrome(s);
            // Output: ccc
            Console.WriteLine(result);

            s = "aaca";
            result = LongestPalindrome(s);
            // Output: aca
            Console.WriteLine(result);

            s = "babad";
            result = LongestPalindrome(s);
            // Output: bab
            Console.WriteLine(result);

            s = "cbbd";
            result = LongestPalindrome(s);
            // Output: bb
            Console.WriteLine(result);

            s = "a";
            result = LongestPalindrome(s);
            // Output: a
            Console.WriteLine(result);

            s = "ac";
            result = LongestPalindrome(s);
            // Output: a
            Console.WriteLine(result);
        }

        public static string LongestPalindrome(string s)
        {
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                string odd = CheckSubstring(s, i, 1);
                string even = CheckSubstring(s, i, 0);

                result = odd.Length > result.Length ? odd : result;
                result = even.Length > result.Length ? even : result;
            }

            return result;
        }

        private static string CheckSubstring(string s, int i, int start)
        {
            StringBuilder result = new StringBuilder();
            if (start == 1)
            {
                result.Append(s[i]);
            }

            int step = start;
            int k = (start + 1) % 2;

            while (i - step >= 0 && i + step + k < s.Length && s[i - step] == s[i + step + k])
            {
                result.Insert(0, s[i - step]);
                result.Append(s[i + step + k]);
                step++;
            }

            return result.ToString();
        }
    }
}