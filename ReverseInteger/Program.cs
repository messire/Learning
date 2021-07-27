using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;

namespace ReverseInteger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Reverse(123));
            Console.WriteLine(Reverse(-120));
            Console.WriteLine(Reverse(1));
        }

        private static int Reverse(int x)
        {
            if (x == int.MaxValue - 1 || x == int.MinValue) return 0;
            if (x > -10 && x < 10) return x;
            int k = 1;
            if (x < 0)
            {
                k = -1;
                x *= k;
            }

            char[] str = $"{x}".ToCharArray();
            int i = 0;
            int len = str.Length - 1;

            while (i < len)
            {
                char tmp = str[i];
                str[i] = str[len];
                str[len] = tmp;
                i++;
                len--;
            }

            string strResult = new string(str);
            int.TryParse(strResult, out int result);

            return result * k;
        }
    }
}