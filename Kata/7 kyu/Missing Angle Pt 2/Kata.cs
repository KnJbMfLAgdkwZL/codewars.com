// Missing Angle Pt 2
// https://www.codewars.com/kata/58e4f4ab020336dc4500093c

namespace codewars.com.Kata._7_kyu.Missing_Angle_Pt_2
{
    using System;

    class Kata
    {
        public static double missingAngle(double a, double b, double c)
        {
            var num = Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2);
            var den = 2.0 * b * c;
            var fra = num / den;
            var ang = Math.Acos(fra) * 180.0 / Math.PI;
            return Math.Round(ang, 1);
        }
    }
}