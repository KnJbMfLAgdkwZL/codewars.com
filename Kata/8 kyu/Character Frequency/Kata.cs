// Character Frequency
// https://www.codewars.com/kata/548ef5b7f33a646ea50000b2

namespace codewars.com.Kata._8_kyu.Character_Frequency
{
    using System.Collections.Generic;

    public class Kata
    {
        public static Dictionary<char, int> CharFreq(string message)
        {
            Dictionary<char, int> res = new Dictionary<char, int>();
            foreach (var v in message)
            {
                if (res.ContainsKey(v))
                    res[v]++;
                else
                    res[v] = 1;
            }

            return res;
        }
    }
}