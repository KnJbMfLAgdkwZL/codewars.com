// Multiply characters
// https://www.codewars.com/kata/52e9aa89b5acdd26d3000127

namespace codewars.com.Kata._7_kyu.Multiply_characters
{
    using System.Linq;

    public class Kata
    {
        public static string Spam(int n)
        {
            const string SpamValue = "hue";
            return string.Concat(Enumerable.Repeat(SpamValue, n));
        }
    }
}