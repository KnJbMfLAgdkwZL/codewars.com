// No oddities here
// https://www.codewars.com/kata/51fd6bc82bc150b28e0000ce

namespace codewars.com.Kata._7_kyu.No_oddities_here
{
    using System.Linq;

    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            return values.Where(v => v % 2 == 0).ToArray();
        }
    }
}