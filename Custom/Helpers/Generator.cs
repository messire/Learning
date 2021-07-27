using System;
using System.Drawing;

namespace Custom.Helpers
{
    public class Generator
    {
        private static readonly Random Random = new Random();
        
        public static Point[] CreatPointCollection(int pointCount, int min, int max)
        {
            Point[] result = new Point[pointCount];

            for (int i = 0; i < pointCount; i++)
            {
                result[i] = CreateNewPoint(max, min);
            }

            return result;
        }

        private static Point CreateNewPoint(int max, int min = 0)
        {
            int x = Random.Next(min, max);
            int y = Random.Next(min, max);

            return new Point(x, y);
        }
    }
}