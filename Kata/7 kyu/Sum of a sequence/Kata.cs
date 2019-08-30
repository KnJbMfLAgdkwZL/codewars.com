// Sum of a sequence
// https://www.codewars.com/kata/586f6741c66d18c22800010a

namespace codewars.com.Kata._7_kyu.Sum_of_a_sequence
{
    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
            var sum = 0;
            for (var i = start; i <= end; i += step)
                sum += i;
            return sum;
        }
    }
}