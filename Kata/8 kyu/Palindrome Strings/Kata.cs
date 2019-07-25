// Palindrome Strings
// https://www.codewars.com/kata/57a5015d72292ddeb8000b31

namespace codewars.com.Kata._8_kyu.Palindrome_Strings
{
    using System.Linq;

    public class Kata
    {
        public static bool IsPalindrome(object line)
        {
            string str = line.ToString();
            return str == new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}