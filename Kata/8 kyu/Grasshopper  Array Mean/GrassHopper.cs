// Grasshopper  Array Mean
// https://www.codewars.com/kata/55d277882e139d0b6000005d

namespace codewars.com.Kata._8_kyu.Grasshopper__Array_Mean
{
    using System.Linq;

    public class GrassHopper
    {
        public static int FindAverage(int[] nums)
        {
            return nums.Sum() / nums.Length;
        }
    }
}