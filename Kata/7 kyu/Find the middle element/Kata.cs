// Find the middle element
// https://www.codewars.com/kata/545a4c5a61aa4c6916000755

namespace codewars.com.Kata._7_kyu.Find_the_middle_element
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int Gimme(double[] inputArray)
        {
            double max = inputArray.Max();
            double min = inputArray.Min();
            double avr = max;
            foreach (var v in inputArray)
            {
                if (max < v)
                    max = v;
                if (min > v)
                    min = v;
                if (min < v && v < max)
                    avr = v;
            }

            return Array.IndexOf(inputArray, avr);
        }
    }
}