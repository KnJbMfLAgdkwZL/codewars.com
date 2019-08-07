// Maximum Length Difference
// https://www.codewars.com/kata/5663f5305102699bad000056

namespace codewars.com.Kata._8_kyu.Maximum_Length_Difference
{
    using System;
    using System.Linq;

    public class MaxDiffLength
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
                return -1;

            var a1min = a1.Select(v => v.Length).Min();
            var a1max = a1.Select(v => v.Length).Max();

            var a2min = a2.Select(v => v.Length).Min();
            var a2max = a2.Select(v => v.Length).Max();

            return Math.Max(Math.Abs(a2max - a1min), Math.Abs(a1max - a2min));
        }
    }
}