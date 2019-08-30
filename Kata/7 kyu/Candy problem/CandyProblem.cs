// Candy problem
// https://www.codewars.com/kata/55466644b5d240d1d70000ba

namespace codewars.com.Kata._7_kyu.Candy_problem
{
    using System.Linq;

    public class CandyProblem
    {
        public static int GetMissingCandies(int[] candies)
        {
            if (candies == null || candies.Length <= 1)
                return -1;
            return candies.Max() * candies.Length - candies.Sum();
        }
    }
}