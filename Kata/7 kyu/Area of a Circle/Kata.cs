// Area of a Circle
// https://www.codewars.com/kata/537baa6f8f4b300b5900106c

namespace codewars.com.Kata._7_kyu.Area_of_a_Circle
{
    using System;

    public static class Kata
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            if (radius.Contains(",") || !double.TryParse(radius, out var rad) || rad <= 0)
                throw new ArgumentException();
            var area = Math.PI * Math.Pow(rad, 2);
            return Math.Round(area, 2);
        }
    }
}