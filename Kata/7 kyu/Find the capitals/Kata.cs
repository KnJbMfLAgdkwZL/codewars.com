// Find the capitals
// https://www.codewars.com/kata/539ee3b6757843632d00026b

namespace codewars.com.Kata._7_kyu.Find_the_capitals
{
    using System.Collections.Generic;

    public static class Kata
    {
        public static int[] Capitals(string word)
        {
            var res = new List<int>();
            for (var i = 0; i < word.Length; i++)
                if (word[i].ToString() == word[i].ToString().ToUpper())
                    res.Add(i);
            return res.ToArray();
        }
    }
}