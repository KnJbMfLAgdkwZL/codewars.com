// Round to the next multiple of 5
// https://www.codewars.com/kata/55d1d6d5955ec6365400006d

namespace codewars.com.Kata._8_kyu.Round_to_the_next_multiple_of_5
{
    public class Kata
    {
        public static int RoundToNext5(int n)
        {
            var m = n % 5;
            if (m == 0)
                return n;
            if (n >= 0)
                return 5 - m + n;
            return n - m;
        }
    }
}