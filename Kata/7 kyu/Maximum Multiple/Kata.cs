// Maximum Multiple
// https://www.codewars.com/kata/5aba780a6a176b029800041c

namespace codewars.com.Kata._7_kyu.Maximum_Multiple
{
    public class Kata
    {
        public static int MaxMultiply(int divisor, int bound)
        {
            for (var i = bound; true; i--)
                if ((double) i / divisor == i / divisor)
                    return i;
        }
    }
}