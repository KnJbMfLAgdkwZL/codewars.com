// String cleaning
// https://www.codewars.com/kata/57e1e61ba396b3727c000251

namespace codewars.com.Kata._8_kyu.String_cleaning
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static string StringClean(string s)
        {
            return Regex.Replace(s, @"[0-9]", "");
        }
    }
}