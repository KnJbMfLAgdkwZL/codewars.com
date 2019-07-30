// Geometry Basics Distance between points in 2D
// https://www.codewars.com/kata/58dced7b702b805b200000be

namespace codewars.com.Kata._8_kyu.Geometry_Basics_Distance_between_points_in_2D
{
    using System;

    public class Kata
    {
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            double x = (double) (b.X - a.X);
            double y = (double) (b.Y - a.Y);

            return Math.Sqrt(x * x + y * y);
        }
    }

    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}