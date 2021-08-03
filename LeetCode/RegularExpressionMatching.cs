using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    // Given an input string s and a pattern p,
    //implement regular expression matching with support for '.' and '*' where:

    // '.' Matches any single character.
    // '*' Matches zero or more of the preceding element.

    // The matching should cover the entire input string (not partial).

    public class RegularExpressionMatching
    {
        public bool Calculate(string s, string p)
        {
            if (!p.Contains("*") && !p.Contains("."))
            {
                return s == p;
            }

            bool start = !string.IsNullOrEmpty(s) && (p[0] == s[0] || p[0] == '.');

            if (p.Length >= 2 && p[1] == '*')
            {
                return Calculate(s, p.Substring(2)) || start && Calculate(s.Substring(1), p);
            }

            return start && Calculate(s.Substring(1), p.Substring(1));
        }
    }
}