using System.Collections.Generic;

namespace LeetCode
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.


    //* 2 <= nums.length <= 10^4
    //* -10^9 <= nums[i] <= 10^9
    //* -10^9 <= target <= 10^9
    //* Only one valid answer exists.

    public class TwoSum
    {
        public int[] Calculate(int[] nums, int target)
        {
            SortedSet<int> sortedSet = new SortedSet<int>(nums);
            int x1 = 0;
            int x2 = 0;

            foreach (int i in sortedSet)
            {
                int x = target - i;
                if (!sortedSet.Contains(x)) continue;
                x1 = i;
                x2 = x;
                break;
            }

            int result1 = -1;
            int result2 = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (result1 != -1 && result2 != -1) break;

                if (result1 == -1 && x1 == nums[i])
                {
                    result1 = i;
                    continue;
                }

                if (result2 == -1 && x2 == nums[i])
                {
                    result2 = i;
                }
            }

            return new[] {result1, result2};
        }

    }
}