// Thinkful  String Drills Repeater
// https://www.codewars.com/kata/585a1a227cb58d8d740001c3

namespace codewars.com.Kata._8_kyu.Thinkful__String_Drills_Repeater
{
    using System.Linq;

    public class Kata
    {
        public static string Repeater(string s, int n)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}