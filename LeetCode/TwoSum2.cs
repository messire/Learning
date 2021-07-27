using System;

namespace LeetCode
{
    //Given an array of integers numbers that is already sorted in non-decreasing order,
    //find two numbers such that they add up to a specific target number.
    
    //Return the indices of the two numbers (1-indexed) as an integer array answer of size 2,
    //where 1 <= answer[0] < answer[1] <= numbers.length.
    
    //The tests are generated such that there is exactly one solution.
    //You may not use the same element twice.
    
    public class TwoSum2
    {
        public int[] Calculate(int[] numbers, int target)
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
    }
}