// Counting power sets
// https://www.codewars.com/kata/54381f0b6f032f933c000108

namespace codewars.com.Kata._7_kyu.Counting_power_sets
{
    using System.Numerics;

    public class Kata
    {
        public static double Powers(int[] list)
        {
            BigInteger res = new BigInteger(1);
            for (int i = 0; i < list.Length; i++)
            {
                res += res;
            }

            return (double) res;
        }
    }
}