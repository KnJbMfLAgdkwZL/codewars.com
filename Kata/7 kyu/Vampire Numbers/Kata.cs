// Vampire Numbers
// https://www.codewars.com/kata/54d418bd099d650fa000032d

namespace codewars.com.Kata._8_kyu.Vampire_Numbers
{
    using System.Linq;

    static class Kata
    {
        public static bool vampire_test(long x, long y)
        {
            var sum = x * y;
            var s1 = new string(sum.ToString().OrderBy(v => v).ToArray());
            var s2 = new string((x.ToString() + y.ToString()).OrderBy(v => v).ToArray());
            if (s1 != s2)
                return false;
            return true;
        }
    }
}