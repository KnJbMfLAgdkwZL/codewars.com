// Sort the Gift Code
// https://www.codewars.com/kata/52aeb2f3ad0e952f560005d3

namespace codewars.com.Kata._8_kyu.Sort_the_Gift_Code
{
    using System.Linq;

    public class Kata
    {
        public static string SortGiftCode(string code)
        {
            return string.Join("", code.OrderBy(v => v));
        }
    }
}