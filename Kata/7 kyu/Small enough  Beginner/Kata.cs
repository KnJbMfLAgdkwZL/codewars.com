// Small enough  Beginner
// https://www.codewars.com/kata/57cc981a58da9e302a000214

namespace codewars.com.Kata._7_kyu.Small_enough__Beginner
{
    using System.Linq;

    public class Kata
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            return a.All(v => v <= limit);
        }
    }
}