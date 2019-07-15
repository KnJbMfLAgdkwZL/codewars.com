// Opposites Attract
// https://www.codewars.com/kata/555086d53eac039a2a000083

namespace codewars.com.Kata._8_kyu.Opposites_Attract
{
    public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return flower1 % 2 == 0 && flower2 % 2 != 0 || flower1 % 2 != 0 && flower2 % 2 == 0;
        }
    }
}