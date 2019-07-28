// Short Long Short
// https://www.codewars.com/kata/50654ddff44f800200000007

namespace codewars.com.Kata._8_kyu.Short_Long_Short
{
    public class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            var s = b;
            var l = a;
            if (a.Length < b.Length)
            {
                s = a;
                l = b;
            }

            return $"{s}{l}{s}";
        }
    }
}