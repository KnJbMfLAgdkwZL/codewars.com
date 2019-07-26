// Contamination 1 String
// https://www.codewars.com/kata/596fba44963025c878000039

namespace codewars.com.Kata._8_kyu.Contamination_1_String
{
    using System.Linq;

    public class Kata
    {
        public static string Contamination(string text, string character)
        {
            return string.Concat(Enumerable.Repeat(character, text.Length));
        }
    }
}