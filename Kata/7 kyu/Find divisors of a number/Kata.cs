// Find divisors of a number
// https://www.codewars.com/kata/542c0f198e077084c0000c2e

namespace codewars.com.Kata._8_kyu.Find_divisors_of_a_number
{
    public class Kata
    {
        public static int Divisors(int n)
        {
            var cnt = 0;
            for (var i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    cnt++;
            cnt++;
            return cnt;
        }
    }
}