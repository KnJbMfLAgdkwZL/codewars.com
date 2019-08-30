// Limit string length  1
// https://www.codewars.com/kata/5208fc3cb613bc725f000142

namespace codewars.com.Kata._7_kyu.Limit_string_length__1
{
    public class Kata
    {
        public static string Limit(string text, int limit)
        {
            if (text.Length <= limit)
                return text;
            return $"{text.Substring(0, limit)}...";
        }
    }
}