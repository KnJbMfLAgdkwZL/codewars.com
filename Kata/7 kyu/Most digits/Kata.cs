// Most digits
// https://www.codewars.com/kata/58daa7617332e59593000006

namespace codewars.com.Kata._8_kyu.Most_digits
{
    using System.Linq;

    public class Kata
    {
        public static int FindLongest(int[] number)
        {
            var len = number.Max().ToString().Length;
            foreach (var v in number)
                if (v.ToString().Length == len)
                    return v;
            return 0;
        }
    }
}