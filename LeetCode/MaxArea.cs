using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class Vector3
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }

    public class MaxArea
    {
        public int Calculate(int[] height)
        {
            int result = 0;
            int i = 0;
            int j = height.Length-1;
            
            while (i < j)
            {
                int length = j - i;
                
                int width = Math.Min(height[i], height[j]);
                int s = length * width;

                result = Math.Max(s, result);
                
                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            

            return result;
        }
    }
}