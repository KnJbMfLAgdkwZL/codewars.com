// Convert to Binary
// https://www.codewars.com/kata/59fca81a5712f9fa4700159a

namespace codewars.com.Kata._8_kyu.Convert_to_Binary
{
    using System;

    public static class Kata
    {
        public static int ToBinary(int n)
        {
            return int.Parse(Convert.ToString(n, 2));
        }
    }
}