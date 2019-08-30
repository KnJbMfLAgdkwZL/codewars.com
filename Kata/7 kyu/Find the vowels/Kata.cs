// Find the vowels
// https://www.codewars.com/kata/5680781b6b7c2be860000036

namespace codewars.com.Kata._7_kyu.Find_the_vowels
{
    using System.Collections.Generic;

    public class Kata
    {
        public static int[] VowelIndices(string word)
        {
            word = word.ToUpper();
            const string vowels = "AEIOUY";
            var res = new List<int>();
            for (var i = 0; i < word.Length; i++)
                if (vowels.Contains(word[i].ToString()))
                    res.Add(i + 1);
            return res.ToArray();
        }
    }
}