// Expressions Matter
// https://www.codewars.com/kata/5ae62fcf252e66d44d00008e

namespace codewars.com.Kata._8_kyu.Expressions_Matter
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            var res = new List<int>();
            res.Add(a + b + c);
            res.Add(a * b * c);
            res.Add(a + b * c);
            res.Add(a * b + c);
            res.Add((a + b) * c);
            res.Add(a * (b + c));
            return res.Max();
        }
    }
}