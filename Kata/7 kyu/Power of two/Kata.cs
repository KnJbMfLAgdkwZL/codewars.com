// Power of two
// https://www.codewars.com/kata/534d0a229345375d520006a0

namespace codewars.com.Kata._8_kyu.Power_of_two
{
    using System;

    public static class Kata
    {
        public static bool PowerOfTwo(int n)
        {
            double s = 1;
            for (int i = 1; s < n; i++)
                s = Math.Pow(2, i);
            return (int) s == n;
        }
    }
}