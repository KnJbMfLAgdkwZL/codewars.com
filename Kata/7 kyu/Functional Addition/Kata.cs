// Functional Addition
// https://www.codewars.com/kata/538835ae443aae6e03000547

namespace codewars.com.Kata._7_kyu.Functional_Addition
{
    using System;

    public static class Kata
    {
        public static Func<double, double> Add(double n)
        {
            return delegate(double d) { return d + n; };
        }
    }
}