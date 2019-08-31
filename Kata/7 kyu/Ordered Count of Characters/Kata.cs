// Ordered Count of Characters
// https://www.codewars.com/kata/57a6633153ba33189e000074

namespace Solution
{
    using System.Linq;
    using System;
    using System.Collections.Generic;

    public class Kata
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var res = new Dictionary<char, int>();
            foreach (var v in input)
            {
                if (res.ContainsKey(v))
                    res[v]++;
                else
                    res[v] = 1;
            }

            return res.Select(v => new Tuple<char, int>(v.Key, v.Value)).ToList();
        }
    }
}