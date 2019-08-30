// Form The Minimum
// https://www.codewars.com/kata/5ac6932b2f317b96980000ca

namespace codewars.com.Kata._7_kyu.Form_The_Minimum
{
    using System.Linq;

    class Kata
    {
        public static long MinValue(int[] a)
        {
            var num = a.Distinct().OrderBy(v => v);
            var str = string.Concat(num);
            return long.Parse(str);
        }
    }
}