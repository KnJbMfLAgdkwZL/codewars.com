// Sum of Odd Cubed Numbers
// https://www.codewars.com/kata/580dda86c40fa6c45f00028a

namespace codewars.com.Kata._7_kyu.Sum_of_Odd_Cubed_Numbers
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int CubeOdd(int[] arr)
        {
            return (int) arr.Select(v =>
            {
                if (v % 2 != 0)
                    return Math.Pow(v, 3);
                return 0;
            }).Sum();
        }
    }
}