// SpeedCode 2  Array Madness
// https://www.codewars.com/kata/56ff6a70e1a63ccdfa0001b1

namespace codewars.com.Kata._8_kyu.SpeedCode_2__Array_Madness
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static bool ArrayMadness(int[] a, int[] b)
        {
            return a.Sum(v => Math.Pow(v, 2)) > b.Sum(v => Math.Pow(v, 3));
        }
    }
}