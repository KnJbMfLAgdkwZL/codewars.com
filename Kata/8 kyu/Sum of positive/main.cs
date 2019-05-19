// https://www.codewars.com/kata/5715eaedb436cf5606000381
// Sum of positive

namespace Sum_of_positive
{
    using System.Linq;

    public class Kata
    {
        private static int PositiveSum(int[] arr)
        {
            return arr.Where(v => v > 0).Sum();
        }
    }
}