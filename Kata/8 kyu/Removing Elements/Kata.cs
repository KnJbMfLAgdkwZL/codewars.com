// Removing Elements
// https://www.codewars.com/kata/5769b3802ae6f8e4890009d2

namespace codewars.com.Kata._8_kyu.Removing_Elements
{
    using System.Linq;

    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr.Where((t, i) => i % 2 == 0 || i == 0).ToArray();
        }
    }
}