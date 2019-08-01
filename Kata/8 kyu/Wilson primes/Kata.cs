// Wilson primes
// https://www.codewars.com/kata/55dc4520094bbaf50e0000cb

namespace codewars.com.Kata._8_kyu.Wilson_primes
{
    using System.Linq;

    public class Kata
    {
        public static bool AmIWilson(int p)
        {
            //huzeifa fucking neerd
            var arr = new[] {5, 13, 563};
            return arr.Contains(p);
        }
    }
}