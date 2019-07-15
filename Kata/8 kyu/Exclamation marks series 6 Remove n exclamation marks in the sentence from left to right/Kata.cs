// Exclamation marks series 6 Remove n exclamation marks in the sentence from left to right
// https://www.codewars.com/kata/57faf7275c991027af000679

namespace codewars.com.Kata._8_kyu.
    Exclamation_marks_series_6_Remove_n_exclamation_marks_in_the_sentence_from_left_to_right
{
    public class Kata
    {
        public static string Remove(string s, int n)
        {
            var res = "";
            var cnt = 0;
            foreach (var v in s)
                if ('!' == v && cnt < n)
                    cnt++;
                else
                    res += v;
            return res;
            //return new Regex("!").Replace(s, "", n);
        }
    }
}