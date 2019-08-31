// Converting integer to currency format
// https://www.codewars.com/kata/54e9554c92ad5650fe00022b

namespace codewars.com.Kata._7_kyu.Converting_integer_to_currency_format
{
    using System.Collections.Generic;

    public class Kata
    {
        public static string ToCurrency(int price)
        {
            var str = price.ToString();
            var res = new List<char>();
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                res.Add(str[i]);
                if (j % 3 == 0 && j != 0)
                    res.Add(',');
            }

            return new string(string.Join("", res));
        }
    }
}