// Sort Numbers
// https://www.codewars.com/kata/5174a4c0f2769dd8b1000003

namespace codewars.com.Kata._8_kyu.Sort_Numbers
{
    using System.Linq;

    public class Kata
    {
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];
            return nums.OrderBy(v => v).ToArray();
        }
    }
}