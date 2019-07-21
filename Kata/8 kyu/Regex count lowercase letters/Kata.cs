// Regex count lowercase letters
// https://www.codewars.com/kata/56a946cd7bd95ccab2000055

namespace codewars.com.Kata._8_kyu.Regex_count_lowercase_letters
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, "[a-z]").Count;
        }
    }
}