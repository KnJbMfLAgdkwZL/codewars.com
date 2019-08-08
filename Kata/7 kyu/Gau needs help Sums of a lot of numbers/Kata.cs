// Gau needs help Sums of a lot of numbers
// https://www.codewars.com/kata/54df2067ecaa226eca000229


namespace codewars.com.Kata._8_kyu.Gau_needs_help_Sums_of_a_lot_of_numbers
{
    public class Kata
    {
        public static long? RangeSum(long n)
        {
            if (n <= 0)
                return null;

            if (n > 10)
                return (long) (n * (n + 1) / 2);

            long sum = 0;
            for (long i = 0; i <= n; i++)
                sum += i;
            return sum;
        }
    }
}