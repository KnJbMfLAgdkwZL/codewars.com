// Are the numbers in order
// https://www.codewars.com/kata/56b7f2f3f18876033f000307

namespace codewars.com.Kata._8_kyu.Are_the_numbers_in_order
{
    using System.Linq;
    using System;

    public class Kata
    {
        public static bool IsAscOrder(int[] arr)
        {
            int next = arr.Min();
            foreach (var v in arr)
            {
                if (v < next)
                    return false;
                next = v;
            }

            return true;
        }
    }
}