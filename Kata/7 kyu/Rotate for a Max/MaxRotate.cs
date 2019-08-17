// Rotate for a Max
// https://www.codewars.com/kata/56a4872cbb65f3a610000026

namespace codewars.com.Kata._8_kyu.Rotate_for_a_Max
{
    using System.Collections.Generic;
    using System.Linq;

    public class MaxRotate
    {
        public static long MaxRot(long n)
        {
            var res = new List<long>();
            var str = n.ToString();
            for (var i = 0; i < str.Length; i++)
            {
                res.Add(long.Parse(str));
                var tmp = str[i];
                var rem = str.Remove(i, 1);
                str = $"{rem}{tmp}";
            }

            return res.Max();
        }
    }
}