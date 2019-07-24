// Heads and Legs
// https://www.codewars.com/kata/574c5075d27783851800169e

namespace codewars.com.Kata._8_kyu.Heads_and_Legs
{
    public class Kata
    {
        public static object Animals(int heads, int legs)
        {
            if (heads == 0 && legs == 0)
                return new int[] {0, 0};

            var cows = -(heads - legs / 2);
            var chickens = heads - cows;

            var l = cows * 4 + chickens * 2;
            var h = cows + chickens;

            if (heads != h || legs != l || chickens < 0 || cows < 0)
                return "No solutions";
            return new int[] {chickens, cows};
        }
    }
}