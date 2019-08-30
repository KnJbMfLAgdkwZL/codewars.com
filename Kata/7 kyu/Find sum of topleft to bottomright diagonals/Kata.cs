// Find sum of topleft to bottomright diagonals
// https://www.codewars.com/kata/5497a3c181dd7291ce000700

namespace codewars.com.Kata._7_kyu.Find_sum_of_topleft_to_bottomright_diagonals
{
    using System;

    public static class Kata
    {
        public static int DiagonalSum(int[,] matrix)
        {
            var len = (int) Math.Sqrt(matrix.Length);
            var sum = 0;
            for (var i = 0; i < len; i++)
                sum += matrix[i, i];
            return sum;
        }
    }
}