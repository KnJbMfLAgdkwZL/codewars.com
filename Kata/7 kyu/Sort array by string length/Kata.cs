// Sort array by string length
// https://www.codewars.com/kata/57ea5b0b75ae11d1e800006c

namespace codewars.com.Kata._7_kyu.Sort_array_by_string_length
{
    using System;

    public class Kata
    {
        public static string[] SortByLength(string[] array)
        {
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            return array;
        }
    }
}