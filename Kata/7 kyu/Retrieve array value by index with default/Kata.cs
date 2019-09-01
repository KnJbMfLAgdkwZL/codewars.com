// Retrieve array value by index with default
// https://www.codewars.com/kata/515ceaebcc1dde8870000001

namespace codewars.com.Kata._7_kyu.Retrieve_array_value_by_index_with_default
{
    using System;

    public static class Kata
    {
        public static int Solution(int[] items, int index, int defaultValue)
        {
            if (items.Length < Math.Abs(index))
                return defaultValue;
            if (index >= 0)
                return items[index];
            return items[items.Length - Math.Abs(index)];
        }
    }
}