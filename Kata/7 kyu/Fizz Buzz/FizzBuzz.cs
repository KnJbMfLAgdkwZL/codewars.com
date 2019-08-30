// Fizz Buzz
// https://www.codewars.com/kata/5300901726d12b80e8000498

namespace codewars.com.Kata._7_kyu.Fizz_Buzz
{
    using System;
    using System.Collections.Generic;

    public class FizzBuzz
    {
        public static string[] GetFizzBuzzArray(int n)
        {
            if (n == 0)
                throw new ArgumentOutOfRangeException();
            var res = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                var str = "";
                if (i % 3 == 0)
                    str += "Fizz";
                if (i % 5 == 0)
                    str += "Buzz";
                if (str.Length == 0)
                    str += i.ToString();
                res.Add(str);
            }

            return res.ToArray();
        }
    }
}