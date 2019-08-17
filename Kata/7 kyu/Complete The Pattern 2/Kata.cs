// Complete The Pattern 2
// https://www.codewars.com/kata/55733d3ef7c43f8b0700007c

namespace codewars.com.Kata._8_kyu.Complete_The_Pattern_2
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public string Pattern(int n)
        {
            if (n < 1)
                return "";
            var list = new List<string>();
            for (var i = 0; i < n; i++)
            {
                var str = string.Concat(Enumerable.Range(1 + i, n - i).Reverse());
                list.Add(str);
            }

            return string.Join('\n', list);
        }
    }
}