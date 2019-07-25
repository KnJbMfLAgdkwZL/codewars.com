// Sum of Multiples
// https://www.codewars.com/kata/57241e0f440cd279b5000829

namespace codewars.com.Kata._8_kyu.Sum_of_Multiples
{
    public class Kata
    {
        public static int SumMul(int a, int N)
        {
            if (a >= N || a <= 0)
                throw new System.ArgumentException();
            var m = N / a;
            var sum = m * (m + 1) / 2;
            var ans = a * sum;
            return ans;
        }
    }
}