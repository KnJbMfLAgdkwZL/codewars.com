// Two Oldest Ages
// https://www.codewars.com/kata/511f11d355fe575d2c000001

namespace codewars.com.Kata._8_kyu.Two_Oldest_Ages
{
    using System.Linq;

    public class LargestTwo
    {
        public static int[] TwoOldestAges(int[] ages)
        {
            var r = ages.OrderByDescending(v => v).ToArray();
            return new int[] {r[1], r[0]};
        }
    }
}