// Drying Potatoes
// https://www.codewars.com/kata/58ce8725c835848ad6000007

namespace codewars.com.Kata._7_kyu.Drying_Potatoes
{
    using System;

    public class DryPotatoes
    {
        public static int Potatoes(int p0, int w0, int p1)
        {
            return (int) Math.Floor((w0 * (100.0 - p0) / (100.0 - p1)));
        }
    }
}