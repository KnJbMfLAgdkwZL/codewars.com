// Performance 1  StringAddition  Need High Speed
// https://www.codewars.com/kata/576cd0e17fdf4645810000bb

namespace codewars.com.Kata._7_kyu.Performance_1__StringAddition__Need_High_Speed
{
    using System;
    using System.Text;

    public static class Kata
    {
        public static string Performance(Func<int> method)
        {
            const int size = 150000;
            var builder = new StringBuilder(size);
            for (var i = 0; i < size; i++)
                builder.Append(method());
            return builder.ToString();
        }
    }
}