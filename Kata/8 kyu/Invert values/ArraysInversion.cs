// Invert values
// https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad

namespace codewars.com.Kata._8_kyu.Invert_values
{
    using System.Linq;

    public class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            return input.Select(v => -v).ToArray();
        }
    }
}