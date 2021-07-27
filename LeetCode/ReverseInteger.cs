namespace LeetCode
{
    //Given a signed 32-bit integer x, return x with its digits reversed.
    //If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

    //Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
    
    public class ReverseInteger
    {
        public int Calculate(int x)
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