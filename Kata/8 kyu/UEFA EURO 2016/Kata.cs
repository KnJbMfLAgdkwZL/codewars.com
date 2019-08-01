// UEFA EURO 2016
// https://www.codewars.com/kata/57613fb1033d766171000d60

namespace codewars.com.Kata._8_kyu.UEFA_EURO_2016
{
    public class Kata
    {
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            if (scores[0] > scores[1])
                return $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
            if (scores[0] < scores[1])
                return $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
            return $"At match {teams[0]} - {teams[1]}, teams played draw.";
        }
    }
}