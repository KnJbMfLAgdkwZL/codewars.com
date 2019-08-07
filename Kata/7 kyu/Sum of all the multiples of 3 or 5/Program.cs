// Sum of all the multiples of 3 or 5
// https://www.codewars.com/kata/57f36495c0bb25ecf50000e7

namespace codewars.com.Kata._8_kyu.Sum_of_all_the_multiples_of_3_or_5
{
    using System.Linq;

    namespace Solution
    {
        public static class Program
        {
            public static int findSum(int n)
            {
                return Enumerable.Range(1, n).Where(v => v % 3 == 0 || v % 5 == 0).Sum();
            }
        }
    }
}