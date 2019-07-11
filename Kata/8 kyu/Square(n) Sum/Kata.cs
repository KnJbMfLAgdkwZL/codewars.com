// Square(n) Sum
// https://www.codewars.com/kata/515e271a311df0350d00000f

namespace codewars.com.Kata._8_kyu.Square_n_Sum
{
    using System.Linq;

    public class Kata
    {
        public static int SquareSum(int[] n)
        {
            return n.Select(v => v * v).Sum();
        }
    }
}