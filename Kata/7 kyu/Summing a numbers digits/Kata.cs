// Summing a numbers digits
// https://www.codewars.com/kata/52f3149496de55aded000410

namespace codewars.com.Kata._8_kyu.Summing_a_numbers_digits
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int SumDigits(int number)
        {
            return Math.Abs(number).ToString().Select(v => int.Parse(v.ToString())).Sum();
        }
    }
}