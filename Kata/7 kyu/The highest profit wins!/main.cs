// https://www.codewars.com/kata/559590633066759614000063
// The highest profit wins!

namespace The_highest_profit_wins
{
    using System.Linq;

    public class MinMax
    {
        public static int[] minMax(int[] lst)
        {
            return new int[] {lst.Min(), lst.Max()};
        }
    }
}