using System;
using System.Text;

namespace LeetCode
{
    // The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
    // (you may want to display this pattern in a fixed font for better legibility)

    // P   A   H   N
    // A P L S I I G
    // Y   I   R
    
    // And then read line by line: "PAHNAPLSIIGYIR"
    // Write the code that will take a string and make this conversion given a number of rows:
    // string convert(string s, int numRows);

    public class ZigZagConversion
    {
        public string Calculate(string s, int numRows)
        {
            numRows = Math.Min(s.Length, numRows);
            StringBuilder[] arr = ConvertToArray(s, numRows);
            string result = ConvertToString(arr, numRows);

            return result;
        }


        private StringBuilder[] ConvertToArray(string s, int numRows)
        {
            StringBuilder[] result = new StringBuilder[numRows];

            bool rev = false;
            int i = 0;

            foreach (char t in s)
            {
                if (result[i] == null)
                {
                    result[i] = new StringBuilder();
                }

                result[i].Append(t);
                if (numRows == 1) continue;
                rev = i == numRows - 1 || i != 0 && rev;
                i += rev ? -1 : 1;
            }

            return result;
        }

        private string ConvertToString(StringBuilder[] array, int numRows)
        {
            string result = string.Empty;
            for (int i = 0; i < numRows; i++)
            {
                result += array[i].ToString();
            }

            return result;
        }
    }
}