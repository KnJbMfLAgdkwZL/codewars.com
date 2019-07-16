// Find numbers which are divisible by given number
// https://www.codewars.com/kata/55edaba99da3a9c84000003b

namespace codewars.com.Kata._8_kyu.Find_numbers_which_are_divisible_by_given_number
{
    using System.Linq;

    public class Kata
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            return numbers.Where(v => v % divisor == 0).ToArray();
        }
    }
}