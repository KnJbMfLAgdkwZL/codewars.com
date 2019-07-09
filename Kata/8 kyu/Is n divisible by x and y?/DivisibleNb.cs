// Is n divisible by x and y?
// https://www.codewars.com/kata/5545f109004975ea66000086

namespace codewars.com.Kata._8_kyu
{
    public class DivisibleNb
    {
        public static bool isDivisible(long n, long x, long y)
        {
            return n % x == 0 && n % y == 0;
        }
    }
}