// Multiple of index
// https://www.codewars.com/kata/5a34b80155519e1a00000009

namespace codewars.com.Kata._8_kyu.Multiple_of_index
{
    using System.Linq;
    using System.Collections.Generic;

    public static class Kata
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            return xs.Where((t, i) => i != 0 && t % i == 0).ToList();
        }
    }
}