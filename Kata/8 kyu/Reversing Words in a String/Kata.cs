// Reversing Words in a String
// https://www.codewars.com/kata/57a55c8b72292d057b000594

namespace codewars.com.Kata._8_kyu.Reversing_Words_in_a_String
{
    using System.Linq;

    public class Kata
    {
        public static string Reverse(string text)
        {
            return string.Join(' ', text.Split(' ').Reverse());
        }
    }
}