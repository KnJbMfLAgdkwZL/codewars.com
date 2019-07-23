// Generate range of integers
// https://www.codewars.com/kata/55eca815d0d20962e1000106

namespace codewars.com.Kata._8_kyu.Generate_range_of_integers
{
    using System.Collections.Generic;

    public class Kata
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            var res = new List<int>();
            for (var i = min; i <= max; i += step)
                res.Add(i);
            return res.ToArray();
        }
    }
}