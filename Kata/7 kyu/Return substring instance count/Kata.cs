// Return substring instance count
// https://www.codewars.com/kata/5168b125faced29f66000005

namespace codewars.com.Kata._8_kyu.Return_substring_instance_count
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static int SubstringCount(string fullText, string searchText)
        {
            return Regex.Matches(fullText, searchText).Count;
        }
    }
}