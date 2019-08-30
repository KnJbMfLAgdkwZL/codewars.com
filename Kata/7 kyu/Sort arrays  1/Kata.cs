// Sort arrays  1
// https://www.codewars.com/kata/51f41b98e8f176e70d0002a8

namespace codewars.com.Kata._7_kyu.Sort_arrays__1
{
    using System.Linq;

    public class Kata
    {
        public static string[] SortMe(string[] names)
        {
            return names.OrderBy(v => v).ToArray();
        }
    }
}