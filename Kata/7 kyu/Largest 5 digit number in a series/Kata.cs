// Largest 5 digit number in a series
// https://www.codewars.com/kata/51675d17e0c1bed195000001

namespace codewars.com.Kata._7_kyu.Largest_5_digit_number_in_a_series
{
    public class Kata
    {
        public static int GetNumber(string str)
        {
            var max = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var len = 5;
                if (i + len >= str.Length)
                    len -= i + len - str.Length;
                var num = int.Parse(str.Substring(i, len));
                if (max < num)
                    max = num;
            }

            return max;
        }
    }
}