// Vowel remover
// https://www.codewars.com/kata/5547929140907378f9000039

namespace codewars.com.Kata._8_kyu.Vowel_remover
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static string Shortcut(string input)
        {
            return Regex.Replace(input, "[aeiou]", "");
        }
    }
}