// Sum without highest and lowest number
// https://www.codewars.com/kata/576b93db1129fcf2200001e6

namespace codewars.com.Kata._8_kyu.Sum_without_highest_and_lowest_number
{
    using System.Linq;

    public static class Kata
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
                return 0;
            return numbers.Sum() - numbers.Max() - numbers.Min();
        }
    }
}