// Find the unique number
// https://www.codewars.com/kata/585d7d5adb20cf33cb000235

namespace Find_the_unique_number
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var dict = new Dictionary<int, int>();
            foreach (var v in numbers)
            {
                if (!dict.ContainsKey(v))
                    dict.Add(v, 0);
                dict[v]++;
            }

            var items = from pair in dict orderby pair.Value ascending select pair;
            return items.ToArray()[0].Key;
        }
    }
}