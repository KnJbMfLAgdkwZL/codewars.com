// A Needle in the Haystack
// https://www.codewars.com/kata/56676e8fabd2d1ff3000000c

namespace codewars.com.Kata._8_kyu.A_Needle_in_the_Haystack
{
    using System;

    public class Kata
    {
        public static string FindNeedle(object[] haystack)
        {
            var res = Array.IndexOf(haystack, "needle");
            return $"found the needle at position {res}";
        }
    }
}