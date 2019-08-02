// Enumerable Magic 2  True for Any
// https://www.codewars.com/kata/54598e89cbae2ac001001135

namespace codewars.com.Kata._8_kyu.Enumerable_Magic_2__True_for_Any
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            return arr.Any(fun);
        }
    }
}