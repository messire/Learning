using System;
using System.Collections.Generic;

namespace LeetCode
{
    //Given a string s, find the length of the longest substring without repeating characters.

    public class LongestSubstring
    {
        public int Calculate(string s)
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