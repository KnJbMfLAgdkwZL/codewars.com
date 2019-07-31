// Compare within margin
// https://www.codewars.com/kata/56453a12fcee9a6c4700009c

namespace codewars.com.Kata._8_kyu.Compare_within_margin
{
    using System;

    public class Kata
    {
        public static int CloseCompare(double a, double b, double margin = 0)
        {
            var min = Math.Min(a, b);
            var max = Math.Max(a, b);
            if (a < b && min + margin < max)
                return -1;
            if (a > b && min + margin < max)
                return 1;
            return 0;
        }
    }
}