// Count by X
// https://www.codewars.com/kata/5513795bd3fafb56c200049e

namespace codewars.com.Kata._8_kyu.Count_by_X
{
    using System.Linq;

    public class Kata
    {
        public static int[] CountBy(int x, int n)
        {
            var nums = Enumerable.Range(1, n);
            return nums.Select(v => v * x).ToArray();
        }
    }
}