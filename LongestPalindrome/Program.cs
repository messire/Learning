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
                StringBuilder odd = new StringBuilder().Append(s[i]);
                StringBuilder even = new StringBuilder();
                int step = 1;

                while (i - step >= 0 && i + step < s.Length && s[i - step] == s[i + step])
                {
                    odd.Insert(0, s[i - step]);
                    odd.Append(s[i + step]);
                    step++;
                }

                step = 0;
                while (i - step >= 0 && i + step + 1 < s.Length && s[i - step] == s[i + step + 1])
                {
                    even.Insert(0, s[i - step]);
                    even.Append(s[i + step + 1]);
                    step++;
                }

                result = odd.Length > result.Length ? odd.ToString() : result;
                result = even.Length > result.Length ? even.ToString() : result;
            }

            return result;
        }
    }
}