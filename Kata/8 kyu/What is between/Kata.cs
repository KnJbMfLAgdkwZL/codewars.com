// What is between
// https://www.codewars.com/kata/55ecd718f46fba02e5000029

namespace codewars.com.Kata._8_kyu.What_is_between
{
    using System.Collections.Generic;

    public static class Kata
    {
        public static int[] Between(int a, int b)
        {
            var min = a < b ? a : b;
            var max = a > b ? a : b;
            var r = new List<int>();
            for (var i = min; i <= max; i++)
                r.Add(i);
            return r.ToArray();
        }
    }
}