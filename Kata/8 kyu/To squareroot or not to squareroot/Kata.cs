// To squareroot or not to squareroot
// https://www.codewars.com/kata/57f6ad55cca6e045d2000627

namespace codewars.com.Kata._8_kyu.To_squareroot_or_not_to_squareroot
{
    using System;
    using System.Collections.Generic;

    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            var res = new List<int>();
            foreach (var v in array)
            {
                var t = Math.Sqrt(v);
                if (t - (int) t == 0)
                    res.Add((int) t);
                else
                    res.Add(v * v);
            }

            return res.ToArray();
        }
    }
}