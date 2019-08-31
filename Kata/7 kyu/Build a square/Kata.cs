// Build a square
// https://www.codewars.com/kata/59a96d71dbe3b06c0200009c

namespace codewars.com.Kata._7_kyu.Build_a_square
{
    using System.Collections.Generic;

    public static class Kata
    {
        public static string GenerateShape(int n)
        {
            var res = new List<string>();
            for (var i = 0; i < n; i++)
                res.Add(new string('+', n));
            return string.Join('\n', res);
        }
    }
}