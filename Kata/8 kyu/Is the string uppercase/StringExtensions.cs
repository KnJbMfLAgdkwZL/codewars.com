// Is the string uppercase
// https://www.codewars.com/kata/56cd44e1aa4ac7879200010b

namespace codewars.com.Kata._8_kyu.Is_the_string_uppercase
{
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string str)
        {
            return str.ToUpper() == str;
        }
    }
}