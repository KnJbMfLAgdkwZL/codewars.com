// Decibel Scale
// https://www.codewars.com/kata/5612a42e746aa62de100001a

namespace codewars.com.Kata._8_kyu.Decibel_Scale
{
    using System;

    public static class Kata
    {
        public static double DbScale(double intensity)
        {
            return 10 * Math.Log10(intensity * Math.Pow(10, 12));
        }
    }
}