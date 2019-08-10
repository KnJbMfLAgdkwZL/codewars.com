// JavaScript Array Filter
// https://www.codewars.com/kata/514a6336889283a3d2000001

namespace codewars.com.Kata._8_kyu.JavaScript_Array_Filter
{
    using System.Linq;

    public class Kata
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(v => v % 2 == 0).ToArray();
        }
    }
}