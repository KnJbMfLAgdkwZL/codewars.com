// Filter out the geese
// https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7

namespace codewars.com.Kata._8_kyu.Filter_out_the_geese
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Filter
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            var geese = new string[] {"African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"};
            return birds.Where(v => !geese.Contains(v));
        }
    }
}