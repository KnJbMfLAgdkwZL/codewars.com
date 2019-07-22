// FIXME Replace all dots
// https://www.codewars.com/kata/596c6eb85b0f515834000049

namespace codewars.com.Kata._8_kyu.FIXME_Replace_all_dots
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static string ReplaceDots(string str)
        {
            return new Regex(@"\.").Replace(str, "-");
        }
    }
}