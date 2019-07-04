// Find the smallest integer in the array
// https://www.codewars.com/kata/55a2d7ebe362935a210000b2

namespace Find_the_smallest_integer_in_the_array
{
    using System.Linq;

    public class Kata
    {
        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }
    }
}