using System;
using System.Threading;

namespace StringToInteger_atoi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("42"));
            Console.WriteLine(MyAtoi("   -42"));
            Console.WriteLine(MyAtoi("4193 with words"));
            Console.WriteLine(MyAtoi("words and 987"));
            Console.WriteLine(MyAtoi("-91283472332"));
        }

        public static int MyAtoi(string s)
        {
            int start = -1;
            int end = -1;

            s = s.TrimStart(' ');

            if (!char.IsDigit(s[0]) && s[0] != '-') return 0;
            string parsed = string.Empty;
            
            for (int i = 0; i < s.Length - 1; i++)
            {
                parsed += s[i];
                if (char.IsDigit(s[i]) && start == -1)
                {
                    start = i;
                }

                if (!char.IsDigit(s[i]) && start != -1 && end == -1)
                {
                    end = i;
                }

                if (start != -1 && end != -1) break;
            }

            if (end == -1)
            {
                end = s.Length - 1;
            }

            //string parsed = s.Substring(start, end - start + 1);

            if (start > 0 && s[start - 1] == '-')
            {
                parsed = parsed.Insert(0, "-");
            }

            long preResult = long.Parse(parsed);

            int result = preResult > int.MaxValue ? int.MaxValue : preResult < int.MinValue ? int.MinValue : int.Parse(parsed);
            return result;
        }
    }
}