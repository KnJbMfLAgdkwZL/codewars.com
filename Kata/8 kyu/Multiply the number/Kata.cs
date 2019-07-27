// Multiply the number
// https://www.codewars.com/kata/5708f682c69b48047b000e07

namespace codewars.com.Kata._8_kyu.Multiply_the_number
{
    using System;

    public class Kata
    {
        public static int Multiply(int number)
        {
            return (int) Math.Pow(5, Math.Abs(number).ToString().Length) * number;
        }
    }
}