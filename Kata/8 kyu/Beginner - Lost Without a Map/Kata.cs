// Beginner - Lost Without a Map
// https://www.codewars.com/kata/57f781872e3d8ca2a000007e

namespace codewars.com.Kata._8_kyu.Beginner_Lost_Without_Map
{
    using System.Linq;

    public class Kata
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(v => v + v).ToArray();
        }
    }
}