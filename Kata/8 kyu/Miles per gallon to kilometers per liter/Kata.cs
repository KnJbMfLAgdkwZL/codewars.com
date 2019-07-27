// Miles per gallon to kilometers per liter
// https://www.codewars.com/kata/557b5e0bddf29d861400005d

namespace codewars.com.Kata._8_kyu.Miles_per_gallon_to_kilometers_per_liter
{
    using System;

    public static class Kata
    {
        public static double Converter(int mpg)
        {
            return Math.Round(mpg * 1.609344 / 4.54609188, 2);
        }
    }
}