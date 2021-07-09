using System;
using System.Collections;
using System.Collections.Generic;

namespace LongestSubstring
{
    //Given a string s, find the length of the longest substring without repeating characters.
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = "abcabcbb";
            int result = LengthOfLongestSubstring(s);
            
            // Output: 3
            Console.WriteLine(result);
            
            s = "bbbbb";
            result = LengthOfLongestSubstring(s);
            
            // Output: 1
            Console.WriteLine(result);
            
            s = "pwwkew";
            result = LengthOfLongestSubstring(s);
            
            // Output: 3
            Console.WriteLine(result);
            
            s = "";
            result = LengthOfLongestSubstring(s);
            
            // Output: 0
            Console.WriteLine(result);
            
            s = "dvdf";
            result = LengthOfLongestSubstring(s);
            
            // Output: 3
            Console.WriteLine(result);
        }
        
        public static int LengthOfLongestSubstring(string s)
        {
            Queue<char> queue = new Queue<char>();
            int max = 0;
            int i = 0;

            while (i < s.Length)
            {
                while (queue.Contains(s[i]))
                {
                    max = Math.Max(queue.Count, max);
                    queue.Dequeue();
                }

                queue.Enqueue(s[i++]);
            }
            
            return Math.Max(queue.Count, max);
        }
    }
}