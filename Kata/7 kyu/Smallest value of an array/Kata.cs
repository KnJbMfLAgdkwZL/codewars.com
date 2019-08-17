// Smallest value of an array
// https://www.codewars.com/kata/544a54fd18b8e06d240005c0


namespace codewars.com.Kata._8_kyu.Smallest_value_of_an_array
{
    using System.Linq;
    using System;

    public class Kata
    {
        public static int FindSmallest(int[] numbers, string toReturn)
        {
            var min = numbers.Min();
            return toReturn == "index" ? Array.IndexOf(numbers, min) : min;
        }
    }
}