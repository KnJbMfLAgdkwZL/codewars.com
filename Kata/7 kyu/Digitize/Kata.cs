// Digitize
// https://www.codewars.com/kata/5417423f9e2e6c2f040002ae

namespace codewars.com.Kata._7_kyu.Digitize
{
    using System.Linq;

    public static class Kata
    {
        public static int[] digitize(int n)
        {
            return n.ToString().Select(v => int.Parse(v.ToString())).ToArray();
        }
    }
}