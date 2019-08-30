// Remove duplicate words
// https://www.codewars.com/kata/5b39e3772ae7545f650000fc

namespace codewars.com.Kata._7_kyu.Remove_duplicate_words
{
    using System.Linq;

    public static class Kata
    {
        public static string RemoveDuplicateWords(string s)
        {
            var res = s.Split(" ").Distinct();
            return string.Join(" ", res);
        }
    }
}