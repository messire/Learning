using System;
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
                StringBuilder tmp = new StringBuilder().Append(s[i]);
                int step = 1;

                while (i - step >= 0 && i + step < s.Length && s[i - step] == s[i + step])
                {
                    tmp.Insert(0, s[i - step]);
                    tmp.Append(s[i + step]);
                    step++;
                }

                result = tmp.Length > result.Length ? tmp.ToString() : result;
            }

            return result;
        }
    }
}