using System;

namespace TwoSumII
{
    // Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
    // Return the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.length.
    // The tests are generated such that there is exactly one solution. You may not use the same element twice.
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new[] {2, 7, 11, 15};
            int target = 9; // [1, 2]

            int[] result = TwoSum(nums, target);
            WriteResult(result);
            
            nums = new[] {2, 3, 4};
            target = 6; // [1, 3]
            
            result = TwoSum(nums, target);
            WriteResult(result);
            
            nums = new[] {-1, 0};
            target = -1; // [1, 2]
            
            result = TwoSum(nums, target);
            WriteResult(result);
        }

        // Result complexity: O(N/2) = O(N)
        public static int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int k = numbers.Length-1;
            while (i < k)
            {
                if (numbers[i] + numbers[k] > target)
                {
                    k--;
                    continue;
                }

                if (numbers[i] + numbers[k] < target)
                {
                    i++;
                    continue;
                }

                if (numbers[i] + numbers[k] == target) return new int[]{i + 1, k + 1};
            }

            throw new Exception();
        }

        private static void WriteResult(int[] result)
        {
            string message = string.Join(", ", result);
            Console.WriteLine($"[ {message} ]");
        }
    }
}