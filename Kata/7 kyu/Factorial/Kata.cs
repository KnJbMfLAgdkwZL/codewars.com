// Factorial
// https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc

namespace codewars.com.Kata._7_kyu.Factorial
{
    using System;
    using System.Linq;

    public static class Kata
    {
        public static int Factorial(int n)
        {
            if (n > 12)
                throw new ArgumentOutOfRangeException();
            if (n == 0)
                return 1;
            return Enumerable.Range(1, n).Aggregate((f, v) => f * v);
        }
    }
}