// Number Of Occurrences
// https://www.codewars.com/kata/52829c5fe08baf7edc00122b

namespace codewars.com.Kata._8_kyu.Number_Of_Occurrences
{
    using System.Linq;

    public class OccurrencesKata
    {
        public static int NumberOfOccurrences(int x, int[] xs)
        {
            return xs.Count(v => v == x);
        }
    }
}