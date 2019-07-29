// Are arrow functions odd
// https://www.codewars.com/kata/559f80b87fa8512e3e0000f5

namespace codewars.com.Kata._8_kyu.Are_arrow_functions_odd
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Kata
    {
        public static List<int> Odds(List<int> values) => values.Where(v => v % 2 != 0).ToList();
    }
}