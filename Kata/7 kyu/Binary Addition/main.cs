// https://www.codewars.com/kata/551f37452ff852b7bd000139
// Binary Addition

namespace codewars.com.Kata._7_kyu.Binary_Addition
{
    using System;

    public class Kata
    {
        public static string AddBinary(int a, int b)
        {
            int value = a + b;
            return Convert.ToString(value, 2);
        }
    }
}