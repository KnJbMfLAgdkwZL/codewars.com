// SequenceSum
// https://www.codewars.com/kata/5436f26c4e3d6c40e5000282

namespace codewars.com.Kata._7_kyu.SequenceSum
{
    using System;
    using System.Collections.Generic;

    public class SequenceSum
    {
        public static int[] SumOfN(int n)
        {
            var num = 1;
            if (n < 0)
                num = -1;
            var sum = 0;
            var res = new List<int>();
            for (int i = 0; i <= Math.Abs(n); i++)
            {
                sum += i * num;
                res.Add(sum);
            }

            return res.ToArray();
        }
    }
}