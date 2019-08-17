// Monotone travel
// https://www.codewars.com/kata/54466996990c921f90000d61

namespace codewars.com.Kata._8_kyu.Monotone_travel
{
    public class Kata
    {
        public static bool IsMonotone(int[] arr)
        {
            var prev = 0;
            foreach (var v in arr)
            {
                if (prev > v)
                    return false;
                prev = v;
            }

            return true;
        }
    }
}