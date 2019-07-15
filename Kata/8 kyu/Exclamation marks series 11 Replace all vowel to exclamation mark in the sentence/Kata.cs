// Exclamation marks series 11 Replace all vowel to exclamation mark in the sentence
// https://www.codewars.com/kata/57fb09ef2b5314a8a90001ed

namespace codewars.com.Kata._8_kyu.Exclamation_marks_series_11_Replace_all_vowel_to_exclamation_mark_in_the_sentence
{
    using System.Text.RegularExpressions;

    public static class Kata
    {
        public static string Replace(string s)
        {
            return Regex.Replace(s, "[aeiouAEIOU]", "!");
        }
    }
}