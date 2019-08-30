// Averages of numbers
// https://www.codewars.com/kata/57d2807295497e652b000139

using System.Collections.Generic;

namespace codewars.com.Kata._7_kyu.Averages_of_numbers
{
    public class Kata
    {
        public static double[] Averages(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0)
                return new double[0];
            var res = new List<double>();
            for (var i = 1; i < numbers.Length; i++)
            {
                var t = numbers[i - 1] + numbers[i];
                res.Add(t / 2.0);
            }

            return res.ToArray();
        }
    }
}