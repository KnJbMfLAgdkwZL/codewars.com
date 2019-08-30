// Average Scores
// https://www.codewars.com/kata/57b68bc7b69bfc8209000307

namespace codewars.com.Kata._7_kyu.Average_Scores
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int Average(int[] scores)
        {
            return (int) Math.Round(scores.Average());
        }
    }
}