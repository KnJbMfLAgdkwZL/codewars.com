// Sort and Star
// https://www.codewars.com/kata/57cfdf34902f6ba3d300001e

namespace codewars.com.Kata._8_kyu.Sort_and_Star
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            return string.Join("***", s.First().ToArray());
        }
    }
}