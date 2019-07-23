// repeatIt
// https://www.codewars.com/kata/557af9418895e44de7000053

namespace codewars.com.Kata._8_kyu.repeatIt
{
    using System.Linq;

    public class RepeatIt
    {
        public static string RepeatString(object toRepeat, int n)
        {
            if (toRepeat != null && toRepeat is string)
                return string.Concat(Enumerable.Repeat(toRepeat, n));
            return "Not a string";
        }
    }
}