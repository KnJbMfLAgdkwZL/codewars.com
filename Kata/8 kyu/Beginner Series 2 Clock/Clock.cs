// Beginner Series 2 Clock
// https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a

namespace codewars.com.Kata._8_kyu.Beginner_Series_2_Clock
{
    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            return ((h * 60 + m) * 60 + s) * 1000;
        }
    }
}