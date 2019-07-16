// Array plus array
// https://www.codewars.com/kata/5a2be17aee1aaefe2a000151

namespace codewars.com.Kata._8_kyu.Array_plus_array
{
    using System.Linq;

    public static class Kata
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}