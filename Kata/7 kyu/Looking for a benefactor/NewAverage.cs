// Looking for a benefactor
// https://www.codewars.com/kata/569b5cec755dd3534d00000f

namespace codewars.com.Kata._7_kyu.Looking_for_a_benefactor
{
    using System;
    using System.Linq;

    public class NewAverage
    {
        public static long NewAvg(double[] arr, double navg)
        {
            var r = arr.Select(v => navg - v).Sum() + navg;
            if (r < 0)
                throw new ArgumentException();
            return (long) Math.Ceiling(r);
        }
    }
}