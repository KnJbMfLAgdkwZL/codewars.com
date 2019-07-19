// Find the first nonconsecutive number
// https://www.codewars.com/kata/58f8a3a27a5c28d92e000144

namespace codewars.com.Kata._8_kyu.Find_the_first_nonconsecutive_number
{
    using System.Linq;

    public class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            var i = arr.First();
            foreach (var v in arr)
            {
                if (v != i)
                    return v;
                i++;
            }

            return null;
        }
    }
}