// Filling an array part 1
// https://www.codewars.com/kata/571d42206414b103dc0006a1

namespace codewars.com.Kata._8_kyu.Filling_an_array_part_1
{
    using System.Linq;

    public class Kata
    {
        public static int[] Arr(int N)
        {
            return Enumerable.Range(0, N).ToArray();
        }
    }
}