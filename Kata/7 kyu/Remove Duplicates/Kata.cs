// Remove Duplicates
// https://www.codewars.com/kata/53e30ec0116393fe1a00060b

namespace codewars.com.Kata._8_kyu.Remove_Duplicates
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static List<int> Unique(List<int> integers)
        {
            return integers.Distinct().ToList();
        }
    }
}