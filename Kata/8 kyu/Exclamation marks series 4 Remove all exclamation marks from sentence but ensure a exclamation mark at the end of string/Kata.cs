// Exclamation marks series 4 Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string
// https://www.codewars.com/kata/57faf12b21c84b5ba30001b0

namespace codewars.com.Kata._8_kyu.
    Exclamation_marks_series_4_Remove_all_exclamation_marks_from_sentence_but_ensure_a_exclamation_mark_at_the_end_of_string
{
    public class Kata
    {
        public static string Remove(string s)
        {
            s = s.Replace("!", "");
            return $"{s}!";
        }
    }
}