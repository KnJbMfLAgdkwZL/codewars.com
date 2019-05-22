// https://www.codewars.com/kata/57f609022f4d534f05000024
// Find the stray number

namespace Find_the_stray_number
{
    using System.Collections.Generic;

    class Solution
    {
        public static int Stray(int[] numbers)
        {
            var dict = new Dictionary<int, int>();
            foreach (var v in numbers)
                if (dict.ContainsKey(v))
                    dict[v]++;
                else
                    dict[v] = 1;
            foreach (var v in dict)
                if (v.Value == 1)
                    return v.Key;
            return 0;
        }
    }
}