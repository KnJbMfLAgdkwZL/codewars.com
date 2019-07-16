// Twice as old
// https://www.codewars.com/kata/5b853229cfde412a470000d0

namespace codewars.com.Kata._8_kyu.Twice_as_old
{
    using System;

    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(dadYears - sonYears * 2);
        }
    }
}