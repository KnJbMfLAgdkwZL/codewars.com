// noobCode 01 SUPERSIZE ME or rather this integer
// https://www.codewars.com/kata/5709bdd2f088096786000008

namespace codewars.com.Kata._8_kyu.noobCode_01_SUPERSIZE_ME_or_rather_this_integer
{
    using System.Linq;

    public class Kata
    {
        public static long SuperSize(long num)
        {
            return long.Parse(string.Concat(num.ToString().OrderBy(c => c).Reverse()));
        }
    }
}