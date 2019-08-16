// Sum of Triangular Numbers
// https://www.codewars.com/kata/580878d5d27b84b64c000b51

namespace codewars.com.Kata._8_kyu.Sum_of_Triangular_Numbers
{
    using System.Linq;

    public class Kata
    {
        public static int SumTriangularNumbers(int n)
        {
            if (n <= 0)
                return 0;
            return (int) Enumerable.Range(1, n).Sum(v => 0.5 * v * (v + 1));
        }
    }
}