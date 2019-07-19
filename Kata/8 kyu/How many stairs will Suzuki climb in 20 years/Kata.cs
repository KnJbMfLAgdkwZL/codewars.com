// How many stairs will Suzuki climb in 20 years
// https://www.codewars.com/kata/56fc55cd1f5a93d68a001d4e

namespace codewars.com.Kata._8_kyu.How_many_stairs_will_Suzuki_climb_in_20_years
{
    using System.Linq;

    public class Kata
    {
        public static long StairsIn20(int[][] stairs)
        {
            return stairs.Sum(v => v.Sum()) * 20;
        }
    }
}