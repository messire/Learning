using System;

namespace Custom
{
    public class ReverseSortCharArray
    {
        public char[] Calculate(char[] array)
        {
            char[] result = array;

            ReverseArray(result, 0, array.Length - 1);
            ReverseWords(result);
            return result;
        }

        private void ReverseArray(char[] array, int startIndex, int endIndex)
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

        private void ReverseWords(char[] array)
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
    }
}