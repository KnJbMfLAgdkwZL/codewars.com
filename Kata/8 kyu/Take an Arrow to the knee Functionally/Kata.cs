// Take an Arrow to the knee Functionally
// https://www.codewars.com/kata/559f3123e66a7204f000009f

namespace codewars.com.Kata._8_kyu.Take_an_Arrow_to_the_knee_Functionally
{
    using System.Linq;

    public class Kata
    {
        public static string ArrowFunc(int[] arr)
        {
            return string.Join("", arr.Select(v => (char) v).ToArray());
        }
    }
}