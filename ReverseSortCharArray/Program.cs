using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseSortCharArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] array =
            {
                'p', 'r', 'a', 'c', 't', 'i', 'c', 'e', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'e', 'r', 'f', 'e', 'c',
                't', ' ', 'y', 'o', 'u', 'r', ' ', 'w', 'o', 'r', 'k', ' ', 'g', 'o', 'o', 'd'
            };

            char[] solution1 = new char[array.Length];
            char[] solution2 = new char[array.Length];
            char[] solution3 = new char[array.Length];
            char[] solution4 = new char[array.Length];

            long t1, t2, t3, t4, t5;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;
            long sum4 = 0;

            int maxIndex = 10000000;

            for (int i = 0; i < maxIndex; i++)
            {
                t1 = DateTime.Now.Ticks;
                solution1 = RunSolution1(array); //15
                t2 = DateTime.Now.Ticks;
                solution2 = RunSolution2(array); //50
                t3 = DateTime.Now.Ticks;
                solution3 = RunSolution3(array); //24
                t4 = DateTime.Now.Ticks;
                solution4 = RunSolution4(array); //8
                t5 = DateTime.Now.Ticks;

                sum1 += t2 - t1;
                sum2 += t3 - t2;
                sum3 += t4 - t3;
                sum4 += t5 - t4;
            }

            WriteConsole("Base:", array);
            Console.WriteLine($"Total:\t\t{sum1}\t{sum2}\t{sum3}\t{sum4}");
            Console.WriteLine($"Average:\t{sum1 / maxIndex}\t{sum2 / maxIndex}\t{sum3 / maxIndex}\t{sum4 / maxIndex}");
            WriteConsole("Solution1:", solution1);
            WriteConsole("Solution2:", solution2);
            WriteConsole("Solution3:", solution3);
            WriteConsole("Solution4:", solution4);
        }

        #region Solution 1

        private static char[] RunSolution1(char[] array)
        {
            IEnumerable<string> temp = new string(array).Split(' ').Reverse();
            char[] result = string.Join(" ", temp).ToCharArray();
            return result;
        }

        #endregion

        #region Solution 2

        private static char[] RunSolution2(char[] array)
        {
            string[] splitted = Split(array);
            string[] reversed = Reverse(splitted);
            string joined = Join(reversed);
            char[] result = Separate(joined);

            return result;
        }

        private static string[] Split(char[] array)
        {
            string[] result = new string[1];
            string word = string.Empty;
            int j = 0;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] != ' ')
                {
                    word += array[index];
                    continue;
                }

                AddToCollection(ref result, word, j++);
                word = string.Empty;
            }

            AddToCollection(ref result, word, j);
            return result;
        }

        private static string[] Reverse(string[] array)
        {
            string[] result = new string[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[j++] = array[i];
            }

            return result;
        }

        private static string Join(string[] array)
        {
            string result = string.Empty;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == null) continue;
                result += $" {array[index]}";
            }

            result = result[0] == ' ' ? result.Remove(0, 1) : result;
            return result;
        }

        private static char[] Separate(string str)
        {
            char[] result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                result[i] = str[i];
            }

            return result;
        }

        #endregion

        #region Solution 3

        private static char[] RunSolution3(char[] array)
        {
            char[] result = new string(array).Split(' ').Reverse().Aggregate((a, b) => $"{a} {b}").ToCharArray();
            return result;
        }

        #endregion

        #region Solution 4

        private static char[] RunSolution4(char[] array)
        {
            char[] result = array;

            ReverseArray(result, 0, array.Length - 1);
            ReverseWords(result);
            return result;
        }

        private static void ReverseArray(char[] array, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                char temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }

        private static void ReverseWords(char[] array)
        {
            int startIndex = 0;
            int endIndex = Array.IndexOf(array, ' ');

            while (endIndex != -1)
            {
                ReverseArray(array, startIndex, endIndex - 1);
                startIndex = endIndex + 1;
                endIndex = Array.IndexOf(array, ' ', startIndex);
            }

            ReverseArray(array, startIndex, array.Length - 1);
        }

        #endregion

        #region Helper

        private static void WriteConsole(string message, char[] array)
        {
            Console.WriteLine(message);
            foreach (char c in array)
            {
                Console.Write($" {c} ");
            }

            Console.WriteLine();
        }

        private static void AddToCollection<T>(ref T[] array, T item, int i)
        {
            CheckAndResize(ref array);
            array[i] = item;
        }

        private static void CheckAndResize<T>(ref T[] array)
        {
            int length = array.Length;
            if (array[length - 1] != null)
            {
                Array.Resize(ref array, length << 1);
            }
        }

        #endregion
    }
}