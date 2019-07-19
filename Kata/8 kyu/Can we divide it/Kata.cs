// Can we divide it
// https://www.codewars.com/kata/5a2b703dc5e2845c0900005a

namespace codewars.com.Kata._8_kyu.Can_we_divide_it
{
    public class Kata
    {
        public static bool is_divide_by(int number, int a, int b)
        {
            return number / (double) a % 1 == 0 && number / (double) b % 1 == 0;
        }
    }
}