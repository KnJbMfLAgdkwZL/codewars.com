// Convert number to reversed array of digits
// https://www.codewars.com/kata/5583090cbe83f4fd8c000051

namespace codewars.com.Kata._8_kyu.Convert_number_to_reversed_array_of_digits
{
    using System.Linq;

    public class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Select(v => long.Parse(v.ToString())).Reverse().ToArray();
        }
    }
}