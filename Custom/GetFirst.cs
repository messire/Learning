using System;
using System.Collections.Generic;
using System.Drawing;

namespace Custom
{
    public class GetFirst
    {
        public IEnumerable<Point> Calculate(Point[] collection, int count)
        {
            if (count <= 0) return null;

            QuickSort(collection);
            IEnumerable<Point> result = TakeFirst(collection, count);

            return result;
        }
        
        private static void QuickSort(Point[] collection)
        {
            QuickSort(collection, 0, collection.Length - 1);
        }

        private static void QuickSort(Point[] collection, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return;

            int halfIndex = Partition(collection, minIndex, maxIndex);
            QuickSort(collection, minIndex, halfIndex - 1);
            QuickSort(collection, halfIndex + 1, maxIndex);
        }
        
        private static int Partition(Point[] collection, int minIndex, int maxIndex)
        {
            int partitionIndex = minIndex;

            for (int i = minIndex; i < maxIndex; i++)
            {
                double vector1 = Math.Sqrt(Math.Pow(collection[i].X, 2) + Math.Pow(collection[i].Y, 2));
                double vector2 = Math.Sqrt(Math.Pow(collection[maxIndex].X, 2) + Math.Pow(collection[maxIndex].Y, 2));
                
                if (vector1 >= vector2) continue;
                Swap(ref collection[partitionIndex], ref collection[i]);
                partitionIndex++;
            }

            Swap(ref collection[partitionIndex], ref collection[maxIndex]);
            return partitionIndex;
        }
        
        private static void Swap(ref Point left, ref Point right)
        {
            Point temp = left;
            left = right;
            right = temp;
        }
        
        private static IEnumerable<Point> TakeFirst(IEnumerable<Point> collection, int count)
        {
            foreach (Point point in collection)
            {
                yield return point;
                if (--count == 0) break;
            }
        }
    }
}