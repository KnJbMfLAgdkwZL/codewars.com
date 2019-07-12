// Reversed Words
// https://www.codewars.com/kata/51c8991dee245d7ddf00000e

namespace codewars.com.Kata._8_kyu.Reversed_Words
{
    using System.Linq;

    public class Kata
    {
        public static string ReverseWords(string str)
        {
            return string.Join(' ', str.Split(' ').Reverse());
        }
    }
}