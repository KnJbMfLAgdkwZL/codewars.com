// Sum of numbers from 0 to N
// https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763

namespace codewars.com.Kata._7_kyu.Sum_of_numbers_from_0_to_N
{
    using System.Linq;

    public class SequenceSum
    {
        public static string ShowSequence(int n)
        {
            if (n == 0)
                return "0=0";
            if (n < 0)
                return $"{n}<0";
            var numbers = Enumerable.Range(0, n + 1).ToArray();
            var numstr = string.Join("+", numbers);
            var sum = numbers.Sum();
            return $"{numstr} = {sum}";
        }
    }
}