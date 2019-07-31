// Enumerable Magic 1  True for All
// https://www.codewars.com/kata/54598d1fcbae2ae05200112c

namespace codewars.com.Kata._8_kyu.Enumerable_Magic_1__True_for_All
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static bool All(int[] arr, Func<int, bool> fun)
        {
            return arr.All(fun);
        }
    }
}