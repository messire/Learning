﻿using System.Collections.Generic;

namespace LeetCode
{
    // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    //
    // Symbol       Value
    // I             1
    // V             5
    // X             10
    // L             50
    // C             100
    // D             500
    // M             1000
    // For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII,
    // which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    //
    // Roman numerals are usually written largest to smallest from left to right.
    // However, the numeral for four is not IIII. Instead, the number four is written as IV.
    // Because the one is before the five we subtract it making four.
    // The same principle applies to the number nine, which is written as IX.
    // There are six instances where subtraction is used:
    //
    // I can be placed before V (5) and X (10) to make 4 and 9. 
    // X can be placed before L (50) and C (100) to make 40 and 90. 
    // C can be placed before D (500) and M (1000) to make 400 and 900.
    // Given a roman numeral, convert it to an integer.

    // Constraints:
    //
    // 1 <= s.length <= 15
    // s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    // It is guaranteed that s is a valid roman numeral in the range [1, 3999].

    public class RomanToInteger
    {
        public int Calculate(string s)
        {
            int result = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "M", 1000 },
                { "CM", 900 },
                { "D", 500 },
                { "CD", 400 },
                { "C", 100 },
                { "XC", 90 },
                { "L", 50 },
                { "XL", 40 },
                { "X", 10 },
                { "IX", 9 },
                { "V", 5 },
                { "IV", 4 },
                { "I", 1 },
            };

            foreach (KeyValuePair<string, int> pair in dict)
            {
                string key = pair.Key;
                while (s.StartsWith(key))
                {
                    result += pair.Value;
                    s = s.Remove(0, key.Length);
                }
            }

            return result;
        }
    }
}