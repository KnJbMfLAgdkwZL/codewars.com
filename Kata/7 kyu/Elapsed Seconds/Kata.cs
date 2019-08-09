// Elapsed Seconds
// https://www.codewars.com/kata/517b25a48557c200b800000c

namespace codewars.com.Kata._8_kyu.Elapsed_Seconds
{
    using System;

    public class Kata
    {
        public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
        {
            return (int) (endDate - startDate).TotalSeconds;
        }
    }
}