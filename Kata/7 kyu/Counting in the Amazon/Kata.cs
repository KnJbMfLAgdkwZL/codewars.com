// Counting in the Amazon
// https://www.codewars.com/kata/55b95c76e08bd5eef100001e

namespace codewars.com.Kata._8_kyu.Counting_in_the_Amazon
{
    using System.Collections.Generic;

    public class Kata
    {
        public static string CountArara(int n)
        {
            int f = n / 2;
            var res = new List<string>();
            for (int i = 0; i < f; i++)
                res.Add("adak");
            for (int i = 0; i < n - f * 2; i++)
                res.Add("anane");
            return string.Join(" ", res);
        }
    }
}