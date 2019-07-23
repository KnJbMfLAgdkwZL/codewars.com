// Get number from string
// https://www.codewars.com/kata/57a37f3cbb99449513000cd8

namespace codewars.com.Kata._8_kyu.Get_number_from_string
{
    using System.Text.RegularExpressions;

    namespace Solution
    {
        public static class Program
        {
            public static int getNumberFromString(string s)
            {
                var res = Regex.Replace(s, "[^0-9]", "");
                return int.Parse(res);
            }
        }
    }
}