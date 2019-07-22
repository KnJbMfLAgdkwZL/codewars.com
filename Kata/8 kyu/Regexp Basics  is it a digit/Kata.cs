// Regexp Basics  is it a digit
// https://www.codewars.com/kata/567bf4f7ee34510f69000032

namespace codewars.com.Kata._8_kyu.Regexp_Basics__is_it_a_digit
{
    public static class Kata
    {
        public static bool Digit(this string s)
        {
            return "0123456789".Contains(s) && s.Length > 0;
        }
    }
}