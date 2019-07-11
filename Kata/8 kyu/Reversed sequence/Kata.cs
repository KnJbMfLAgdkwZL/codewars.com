// Reversed sequence
// https://www.codewars.com/kata/5a00e05cc374cb34d100000d

namespace codewars.com.Kata._8_kyu.Reversed_sequence
{
    using System.Collections.Generic;

    public class Kata
    {
        public static int[] ReverseSeq(int n)
        {
            List<int> r = new List<int>();
            for (int i = n; i > 0; i--)
                r.Add(i);
            return r.ToArray();
        }
    }
}