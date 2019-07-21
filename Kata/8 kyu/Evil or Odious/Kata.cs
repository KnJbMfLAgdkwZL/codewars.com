// Evil or Odious
// https://www.codewars.com/kata/56fcfad9c7e1fa2472000034

namespace codewars.com.Kata._8_kyu.Evil_or_Odious
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static string Evil(int n)
        {
            var count = Convert.ToString(n, 2).Count(v => v == '1');
            return count % 2 == 0 ? "It's Evil!" : "It's Odious!";
        }
    }
}