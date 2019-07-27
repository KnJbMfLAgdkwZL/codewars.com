// Nth Power
// https://www.codewars.com/kata/57d814e4950d8489720008db

namespace codewars.com.Kata._8_kyu.Nth_Power
{
    using System;

    public class Kata
    {
        public static double Index(int[] array, int n)
        {
            if (array.Length <= n)
                return -1;
            var r = array[n];
            return Math.Pow(r, n);
        }
    }
}