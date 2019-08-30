// Triangular Treasure
// https://www.codewars.com/kata/525e5a1cb735154b320002c8

namespace codewars.com.Kata._7_kyu.Triangular_Treasure
{
    public class Kata
    {
        public static int Triangular(int n)
        {
            if (n < 0)
                n = 0;
            return n * (n + 1) / 2;
        }
    }
}