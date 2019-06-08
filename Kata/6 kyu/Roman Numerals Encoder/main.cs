// Roman Numerals Encoder
// https://www.codewars.com/kata/51b62bf6a9c58071c600001b

namespace Roman_Numerals_Encoder
{
    using System.Linq;
    using System.Collections.Generic;

    public class RomanConvert
    {
        public static string Solution(int n)
        {
            var dict = new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };
            var keys = dict.Keys;
            var i = 0;
            var res = "";
            while (n > 0)
            {
                var k = keys.ElementAt(i);
                var v = dict[k];
                if (n - k >= 0)
                {
                    n -= k;
                    res += v;
                    continue;
                }

                i++;
            }

            return res;
        }
    }
}