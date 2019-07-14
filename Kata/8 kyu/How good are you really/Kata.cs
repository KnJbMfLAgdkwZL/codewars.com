// How good are you really
// https://www.codewars.com/kata/5601409514fc93442500010b

namespace codewars.com.Kata._8_kyu.How_good_are_you_really
{
    using System.Linq;

    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Average() < YourPoints;
        }
    }
}