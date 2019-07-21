// Formatting decimal places 0
// https://www.codewars.com/kata/5641a03210e973055a00000d

namespace codewars.com.Kata._8_kyu.Formatting_decimal_places_0
{
    using System;

    public class Numbers
    {
        public static double TwoDecimalPlaces(double number)
        {
            return Math.Round(number, 2);
        }
    }
}