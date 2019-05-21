// https://www.codewars.com/kata/563cf89eb4747c5fb100001b
// Remove the minimum

namespace Remove_the_minimum
{
    using System.Collections.Generic;
    using System.Linq;

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            var res = new List<int>();
            if (numbers.Count <= 0) return res;
            var qwe = true;
            var min = numbers.Min();
            foreach (var v in numbers)
                if (qwe != true || v != min)
                    res.Add(v);
                else
                    qwe = false;
            return res;
        }
    }
}