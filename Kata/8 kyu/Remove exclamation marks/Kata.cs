// Remove exclamation marks
// https://www.codewars.com/kata/57a0885cbb9944e24c00008e

namespace codewars.com.Kata._8_kyu.Remove_exclamation_marks
{
    public class Kata
    {
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", string.Empty);
        }
    }
}