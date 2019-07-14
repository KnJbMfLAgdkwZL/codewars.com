// Stringy Strings
// https://www.codewars.com/kata/563b74ddd19a3ad462000054

namespace codewars.com.Kata._8_kyu.Stringy_Strings
{
    public class Kata
    {
        public static string Stringy(int size)
        {
            var res = "";
            for (var i = 1; i <= size; i++)
                res += i % 2;
            return res;
        }
    }
}