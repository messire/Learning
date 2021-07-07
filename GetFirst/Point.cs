using System;

namespace GetFirst
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public double Vector { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            Vector = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public override string ToString() => $"{{ X = {X}, Y = {Y}, Vector = {Vector:F} }}";
    }
}