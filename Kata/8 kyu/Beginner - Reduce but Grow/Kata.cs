// Beginner Reduce but Grow
// https://www.codewars.com/kata/57f780909f7e8e3183000078

namespace codewars.com.Kata._8_kyu.Beginner_Reduce_but_Grow
{
    using System.Linq;

    public class Kata
    {
        public static int Grow(int[] x)
        {
            return x.Aggregate(1, (current, v) => current * v);
        }
    }
}