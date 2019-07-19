// Bin to Decimal
// https://www.codewars.com/kata/57a5c31ce298a7e6b7000334

namespace codewars.com.Kata._8_kyu.Bin_to_Decimal
{
    using System;

    public static class Program
    {
        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }
    }
}