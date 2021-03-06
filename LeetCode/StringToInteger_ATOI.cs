using System.Numerics;

namespace LeetCode
{
    //Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer
    //(similar to C/C++'s atoi function).

    //The algorithm for myAtoi(string s) is as follows:

    //Read in and ignore any leading whitespace.
    //Check if the next character (if not already at the end of the string) is '-' or '+'.
    //Read this character in if it is either. This determines if the final result is negative or positive respectively.
    //Assume the result is positive if neither is present.
    //Read in next the characters until the next non-digit charcter or the end of the input is reached.
    //The rest of the string is ignored.
    //Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32).
    //If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
    //If the integer is out of the 32-bit signed integer range [-231, 231 - 1],
    //then clamp the integer so that it remains in the range.
    //Specifically, integers less than -231 should be clamped to -231,
    //and integers greater than 231 - 1 should be clamped to 231 - 1.
    //Return the integer as the final result.

    //Note:
    //Only the space character ' ' is considered a whitespace character.
    //Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.

    public class StringToInteger_ATOI
    {
        public int Calculate(string s)
        {
            int start = -1;
            int end = -1;

            s = TrimSpace(s);

            if (s.Length == 0 || !char.IsDigit(s[0]) && s[0] != '+' && s[0] != '-') return 0;

            for (int i = 0; i < s.Length; i++)
            {
                start = CheckStart(s[i], start, i);
                end = CheckEnd(s[i], end, i);

                if (end != -1) break;
            }

            if (start == -1) return 0;
            end = end == -1 ? s.Length - 1 : end;

            string parsed = s.Substring(start, end - start + 1);

            if (start > 0 && (s[start - 1] == '+' || s[start-1] == '-'))
            {
                parsed = parsed.Insert(0, $"{s[start - 1]}");
            }

            BigInteger preResult = BigInteger.Parse(parsed);

            int result = preResult > int.MaxValue ? int.MaxValue : preResult < int.MinValue ? int.MinValue : int.Parse(parsed);
            return result;
        }

        private string TrimSpace(string s)
        {
            return s.TrimStart(' ');
        }

        private int CheckStart(char c, int start, int i)
        {
            return char.IsDigit(c) && start == -1 ? i : start;
        }

        private int CheckEnd(char c, int end, int i)
        {
            return !char.IsDigit(c) ? i - 1 : end;
        }
    }
}