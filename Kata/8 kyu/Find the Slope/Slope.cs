// Find the Slope
// https://www.codewars.com/kata/55a75e2d0803fea18f00009d

namespace codewars.com.Kata._8_kyu.Find_the_Slope
{
    using System;

    public class Slope
    {
        public String slope(int[] points)
        {
            var y = points[3] - points[1];
            var x = points[2] - points[0];
            if (x != 0)
            {
                var res = y / x;
                return res.ToString();
            }

            return "undefined";
        }
    }
}