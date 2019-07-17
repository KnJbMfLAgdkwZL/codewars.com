// Powers of 2
// https://www.codewars.com/kata/57a083a57cb1f31db7000028

namespace codewars.com.Kata._8_kyu.Powers_of_2
{
    using System.Numerics;
    using System;
    using System.Collections.Generic;

    public class Kata
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            var res = new List<BigInteger>();
            for (var i = 0; i < n + 1; i++)
                res.Add((BigInteger) Math.Pow(2, i));

            return res.ToArray();
        }
    }
}