// Factorial Factory
// https://www.codewars.com/kata/528e95af53dcdb40b5000171

namespace codewars.com.Kata._8_kyu.Factorial_Factory
{
    using System;

    public static class Kata
    {
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            if (n < 0)
                throw new Exception();

            var res = 1;
            for (var i = 1; i <= n; i++)
                res *= i;
            return res;
        }
    }
}