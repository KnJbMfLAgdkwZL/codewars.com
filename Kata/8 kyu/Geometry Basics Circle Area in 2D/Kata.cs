// Geometry Basics Circle Area in 2D
// https://www.codewars.com/kata/58e3f824a33b52c1dc0001c0

namespace codewars.com.Kata._8_kyu.Geometry_Basics_Circle_Area_in_2D
{
    using System;

    public static class Kata
    {
        public static double CircleArea(Circle circle)
        {
            return Math.PI * (circle.Radius * circle.Radius);
        }
    }

    public class Circle
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }

        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
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