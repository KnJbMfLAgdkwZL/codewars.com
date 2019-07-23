// Exclamation marks series 2 Remove all exclamation marks from the end of sentence
// https://www.codewars.com/kata/57faece99610ced690000165

namespace codewars.com.Kata._8_kyu.Exclamation_marks_series_2_Remove_all_exclamation_marks_from_the_end_of_sentence
{
    using System.Linq;

    public class Kata
    {
        public static string Remove(string s)
        {
            while (s.Last() == '!')
                s = s.Substring(0, s.Length - 1);
            return s;
        }
    }
}