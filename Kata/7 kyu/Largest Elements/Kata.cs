// Largest Elements
// https://www.codewars.com/kata/53d32bea2f2a21f666000256

namespace codewars.com.Kata._8_kyu.Largest_Elements
{
    using System.Linq;
    using System.Collections.Generic;

    public class Kata
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            xs.Sort();
            return xs.Skip(xs.Count - n).ToList();
        }
    }
}