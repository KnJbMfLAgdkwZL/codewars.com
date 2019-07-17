// Exclamation marks series 1 Remove a exclamation mark from the end of string
// https://www.codewars.com/kata/57fae964d80daa229d000126

namespace codewars.com.Kata._8_kyu.Exclamation_marks_series_1_Remove_a_exclamation_mark_from_the_end_of_string
{
    using System.Linq;

    public class Kata
    {
        public static string Remove(string s)
        {
            return s.Last() == '!' ? s.Substring(0, s.Length - 1) : s;
        }
    }
}