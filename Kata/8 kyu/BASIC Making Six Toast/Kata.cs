// BASIC Making Six Toast
// https://www.codewars.com/kata/5834fec22fb0ba7d080000e8

namespace codewars.com.Kata._8_kyu.BASIC_Making_Six_Toast
{
    public class Kata
    {
        public static int SixToast(int num)
        {
            var r = num - 6;
            return (r < 0) ? -r : r;
        }
    }
}