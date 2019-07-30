// Smallest unused ID
// https://www.codewars.com/kata/55eea63119278d571d00006a

namespace codewars.com.Kata._8_kyu.Smallest_unused_ID
{
    using System.Linq;

    public class Kata
    {
        public static int NextId(int[] ids)
        {
            int i = 0;
            while (ids.Contains(i))
                i++;
            return i;
        }
    }
}