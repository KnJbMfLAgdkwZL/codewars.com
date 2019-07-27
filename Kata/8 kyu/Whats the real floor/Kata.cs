// Whats the real floor
// https://www.codewars.com/kata/574b3b1599d8f897470018f6

namespace codewars.com.Kata._8_kyu.Whats_the_real_floor
{
    public static class Kata
    {
        public static int GetRealFloor(int n)
        {
            if (n > 13)
                return n - 2;
            if (n > 0)
                return n - 1;
            return n;
        }
    }
}