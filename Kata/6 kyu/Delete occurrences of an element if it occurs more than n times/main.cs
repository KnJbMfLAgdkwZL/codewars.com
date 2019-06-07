// Delete occurrences of an element if it occurs more than n times
// https://www.codewars.com/kata/554ca54ffa7d91b236000023

namespace Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times
{
    using System.Collections.Generic;

    public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var res = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var v in arr)
            {
                if (!dict.ContainsKey(v))
                    dict.Add(v, 0);
                if (dict[v] >= x) continue;
                dict[v]++;
                res.Add(v);
            }

            return res.ToArray();
        }
    }
}