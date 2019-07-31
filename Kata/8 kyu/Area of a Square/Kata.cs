// Area of a Square
// https://www.codewars.com/kata/5748838ce2fab90b86001b1a

namespace codewars.com.Kata._8_kyu.Area_of_a_Square
{
    using System;

    public class Kata
    {
        public static double SquareArea(double A)
        {
            if (A == 0)
                return 0;
            var a = A / Math.PI;
            var b = Math.Pow(a, 2);
            var c = b * 4;
            var res = Math.Round(c, 2);
            return res;
        }
    }
}