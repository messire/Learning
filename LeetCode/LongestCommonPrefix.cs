using System.Text;

namespace LeetCode
{
    public class LongestCommonPrefix
    {
        public string Calculate(string[] args)
        {
            if (args.Length == 0) return "";
            if (args.Length == 1) return args[0];

            string result = Compare(args[0], args[1]);

            for (int i = 2; i < args.Length; i++)
            {
                result = Compare(result, args[i]);
            }

            return result;
        }

        private string Compare(string first, string second)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < first.Length && i < second.Length)
            {
                if (first[i] != second[i]) break;
                result.Append(first[i]);
                i++;
            }

            return result.ToString();
        }
    }
}