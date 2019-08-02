// Take the Derivative
// https://www.codewars.com/kata/5963c18ecb97be020b0000a2

namespace codewars.com.Kata._8_kyu.Take_the_Derivative
{
    public class Kata
    {
        public static string Derive(double coefficient, double exponent)
        {
            return $"{coefficient * exponent}x^{exponent - 1}";
        }
    }
}