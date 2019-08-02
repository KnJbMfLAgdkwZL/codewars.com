// Enumerable Magic 4  True for None
// https://www.codewars.com/kata/545993ee52756d98ca0010e1

namespace codewars.com.Kata._8_kyu.Enumerable_Magic_4__True_for_None
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static bool None(int[] arr, Func<int, bool> fun)
        {
            return !arr.Any(fun);
        }
    }
}