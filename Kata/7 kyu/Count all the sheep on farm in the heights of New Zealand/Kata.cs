// Count all the sheep on farm in the heights of New Zealand
// https://www.codewars.com/kata/58e0f0bf92d04ccf0a000010

namespace codewars.com.Kata._7_kyu.Count_all_the_sheep_on_farm_in_the_heights_of_New_Zealand
{
    using System.Linq;

    namespace CodeWars
    {
        public class Kata
        {
            public int lostSheep(int[] friday, int[] saturday, int total)
            {
                return total - friday.Sum() - saturday.Sum();
            }
        }
    }
}