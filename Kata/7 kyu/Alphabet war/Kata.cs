// Alphabet war
// https://www.codewars.com/kata/59377c53e66267c8f6000027

namespace codewars.com.Kata._7_kyu.Alphabet_war
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static string AlphabetWar(string fight)
        {
            var powers = new Dictionary<char, int>
            {
                {'w', 4},
                {'p', 3},
                {'b', 2},
                {'s', 1},
                {'m', -4},
                {'q', -3},
                {'d', -2},
                {'z', -1}
            };
            var score = fight.Where(v => powers.ContainsKey(v)).Sum(v => powers[v]);
            if (score < 0)
                return "Right side wins!";
            if (score > 0)
                return "Left side wins!";
            return "Let's fight again!";
        }
    }
}