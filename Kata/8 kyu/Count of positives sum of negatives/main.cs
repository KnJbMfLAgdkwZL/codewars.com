// Count of positives / sum of negatives
// https://www.codewars.com/kata/576bb71bbbcf0951d5000044

namespace Count_of_positives_sum_of_negatives
{
    using System.Linq;

    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
                return new int[0];
            return new int[] {input.Count(v => v > 0), input.Where(v => v < 0).Sum()};
        }
    }
}