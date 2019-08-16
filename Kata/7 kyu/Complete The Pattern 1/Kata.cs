// Complete The Pattern 1
// https://www.codewars.com/kata/5572f7c346eb58ae9c000047

namespace codewars.com.Kata._8_kyu.Complete_The_Pattern_1
{
    using System.Linq;

    public class Kata
    {
        public string Pattern(int n)
        {
            if (n <= 0)
                return "";
            var res = Enumerable.Range(1, n).Select(v => string.Concat(Enumerable.Repeat(v, v)));
            return string.Join('\n', res);
        }
    }
}