// Collatz Conjecture Length
// https://www.codewars.com/kata/54fb963d3fe32351f2000102

namespace codewars.com.Kata._8_kyu.Collatz_Conjecture_Length
{
    public class Kata
    {
        public static int Collatz(int n)
        {
            var i = 1;
            while (n != 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = n * 3 + 1;
                i++;
            }

            return i;
        }
    }
}