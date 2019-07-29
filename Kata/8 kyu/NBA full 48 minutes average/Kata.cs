// NBA full 48 minutes average
// https://www.codewars.com/kata/587c2d08bb65b5e8040004fd

namespace codewars.com.Kata._8_kyu.NBA_full_48_minutes_average
{
    using System;

    public class Kata
    {
        public static double NbaExtrap(double ppg, double mpg)
        {
            if (ppg == 0)
                return 0;
            var r = 48.0 / (mpg / ppg);
            return Math.Round(r, 1);
        }
    }
}