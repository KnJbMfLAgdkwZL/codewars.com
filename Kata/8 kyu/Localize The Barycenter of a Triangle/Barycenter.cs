// Localize The Barycenter of a Triangle
// https://www.codewars.com/kata/5601c5f6ba804403c7000004

namespace codewars.com.Kata._8_kyu.Localize_The_Barycenter_of_a_Triangle
{
    using System;

    public class Barycenter
    {
        public static double[] BarTriang(double[] a, double[] b, double[] c)
        {
            var x = (a[0] + b[0] + c[0]) / 3;
            var y = (a[1] + b[1] + c[1]) / 3;
            x = Math.Round(x, 4);
            y = Math.Round(y, 4);
            return new double[] {x, y};
        }
    }
}