// Collatz Conjecture 3n 1
// https://www.codewars.com/kata/577a6e90d48e51c55e000217

namespace codewars.com.Kata._8_kyu.Collatz_Conjecture_3n_1
{
    public class Kata
    {
        public static uint Hotpo(uint n)
        {
            uint i = 0;
            for (var num = n; num > 1; i++)
            {
                switch (num % 2)
                {
                    case 0:
                        num /= 2;
                        break;
                    case 1:
                        num = 3 * num + 1;
                        break;
                }
            }

            return i;
        }
    }
}