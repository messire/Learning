using System;
using System.Collections.Generic;

namespace GetFirst
{
public class Program
    {
        private static Random _random;

        public static void Main(string[] args)
        {
            _random = new Random();

            Point[] points = GeneratePoints(20, 0, 10);
            WriteCollection("Original collection", points);
            
            IEnumerable<Point> result = GetNearest(points, 5);

            WriteCollection("Sorted collection", points);
            WriteCollection("Filtered collection", result);
        }

        #region Generate array

        private static Point[] GeneratePoints(int pointCount, int min, int max)
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
            int x = _random.Next(min, max);
            int y = _random.Next(min, max);

            return new Point(x, y);
        }

        #endregion

        private static IEnumerable<Point> GetNearest(Point[] collection, int count)
        {
            if (count <= 0) return null;

            QuickSort(collection);
            IEnumerable<Point> result = TakeFirst(collection, count);

            return result;
        }

        #region Sort

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
                if (collection[i].Vector >= collection[maxIndex].Vector) continue;
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

        #endregion

        private static IEnumerable<Point> TakeFirst(IEnumerable<Point> collection, int count)
        {
            foreach (Point point in collection)
            {
                yield return point;
                if (--count == 0) break;
            }
        }

        #region Helpers

        private static void WriteCollection(string message, IEnumerable<Point> collection)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(message);
            message = collection == null ? "Collection is empty" : string.Join($"{Environment.NewLine}", collection);
            Console.WriteLine(message);
        }

        #endregion
    }
}