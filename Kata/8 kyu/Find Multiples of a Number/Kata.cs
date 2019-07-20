// Find Multiples of a Number
// https://www.codewars.com/kata/58ca658cc0d6401f2700045f

namespace codewars.com.Kata._8_kyu.Find_Multiples_of_a_Number
{
    using System.Collections.Generic;

    public class Kata
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
            var res = new List<int>();
            for (var i = 1; integer * i <= limit; i++)
                res.Add(integer * i);
            return res;
        }
    }
}