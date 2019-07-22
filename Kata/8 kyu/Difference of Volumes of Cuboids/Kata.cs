// Difference of Volumes of Cuboids
// https://www.codewars.com/kata/58cb43f4256836ed95000f97

namespace codewars.com.Kata._8_kyu.Difference_of_Volumes_of_Cuboids
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int FindDifference(int[] a, int[] b)
        {
            var am = a.Aggregate((t, v) => t * v);
            var bm = b.Aggregate((t, v) => t * v);
            return Math.Abs(am - bm);
        }
    }
}