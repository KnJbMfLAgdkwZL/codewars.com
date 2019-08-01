// Find the Difference in Age between Oldest and Youngest Family Members
// https://www.codewars.com/kata/5720a1cb65a504fdff0003e2

namespace codewars.com.Kata._8_kyu.Find_the_Difference_in_Age_between_Oldest_and_Youngest_Family_Members
{
    using System.Linq;

    public class Kata
    {
        public static int[] DifferenceInAges(int[] ages)
        {
            if (ages.Length == 0)
                return new int[0];
            var min = ages.Min();
            var max = ages.Max();
            return new[] {min, max, max - min};
        }
    }
}