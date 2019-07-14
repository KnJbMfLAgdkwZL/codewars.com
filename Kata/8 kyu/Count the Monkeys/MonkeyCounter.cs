// Count the Monkeys
// https://www.codewars.com/kata/56f69d9f9400f508fb000ba7

namespace codewars.com.Kata._8_kyu.Count_the_Monkeys
{
    using System.Linq;

    public static class MonkeyCounter
    {
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}