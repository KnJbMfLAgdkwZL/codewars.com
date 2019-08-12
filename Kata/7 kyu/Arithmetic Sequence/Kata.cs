// Arithmetic Sequence
// https://www.codewars.com/kata/540f8a19a7d43d24ac001018

namespace codewars.com.Kata._8_kyu.Arithmetic_Sequence
{
    public class Kata
    {
        public static int Nthterm(int first, int n, int c)
        {
            var cur = first;
            for (var i = 0; i < n; i++)
                cur += c;
            return cur;
        }
    }
}