// Thinkful  Number Drills Pixelart planning
// https://www.codewars.com/kata/58630e2ae88af44d2b0000ea

namespace codewars.com.Kata._8_kyu.Thinkful__Number_Drills_Pixelart_planning
{
    public static class Kata
    {
        public static bool IsDivisible(int wallLength, int pixelSize)
        {
            var d = (double) wallLength / (double) pixelSize;
            return d - (int) d == 0;
        }
    }
}