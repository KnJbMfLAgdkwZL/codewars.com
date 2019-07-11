// Reversed Strings
// https://www.codewars.com/kata/5168bb5dfe9a00b126000018

namespace codewars.com.Kata._8_kyu.Reversed_Strings
{
    using System.Linq;

    public class Kata
    {
        public static string Solution(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}