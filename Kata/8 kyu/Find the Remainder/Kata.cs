// Find the Remainder
// https://www.codewars.com/kata/524f5125ad9c12894e00003f

namespace codewars.com.Kata._8_kyu.Find_the_Remainder
{
    using System;

    public class Kata
    {
        public static int Remainder(int a, int b)
        {
            var max = Math.Max(a, b);
            var min = Math.Min(a, b);
            if (min == 0)
                throw new DivideByZeroException();
            return max % min;
        }
    }
}