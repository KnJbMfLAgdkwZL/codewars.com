// Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!
// https://www.codewars.com/kata/5626b561280a42ecc50000d1

namespace Take_a_Number_And_Sum_Its_Digits_Raised_To_The_Consecutive_Powers_And_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumDigPower
    {
        public static long[] SumDigPow(long a, long b)
        {
            var res = new List<long>();
            for (var i = a; i <= b; i++)
            {
                var str = i.ToString();
                var sum = str.Select(v => Int32.Parse(v.ToString())).Select((t, j) => Math.Pow(t, j + 1))
                    .Aggregate<double, long>(0, (current, r) => current + (int) r);
                if (i == sum)
                    res.Add(i);
            }

            return res.ToArray();
        }
    }
}