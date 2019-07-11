// Double Char
// https://www.codewars.com/kata/56b1f01c247c01db92000076

namespace codewars.com.Kata._8_kyu.Double_Char
{
    using System.Linq;

    public class Kata
    {
        public static string DoubleChar(string s)
        {
            return string.Join("", s.ToArray().Select(v => v.ToString() + v));
        }
    }
}