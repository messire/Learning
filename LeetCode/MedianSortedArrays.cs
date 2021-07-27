namespace LeetCode
{
    // Given two sorted arrays nums1 and nums2 of size m and n respectively,
    // return the median of the two sorted arrays.
    // The overall run time complexity should be O(log (m+n)).
    
    public class MedianSortedArrays
    {
        public double Calculate(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int length3 = length1 + length2;
            if (length3 == 0) return 0;

            int[] array = new int[length3];

            int i = 0;
            int j = 0;
            while (i + j < length3)
            {
                if (length1 == i)
                {
                    array[i + j] = nums2[j++];
                    continue;
                }

                if (length2 == j)
                {
                    array[i + j] = nums1[i++];
                    continue;
                }

                array[i + j] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
            }

            if (length3 == 1) return array[0];
            int m = length3 / 2;
            int k = length3 % 2;

            double result = array[m--];

            if (k == 0)
            {
                result += array[m];
            }

            return result / (2 - k);
        }
    }
}