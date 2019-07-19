// Remove duplicates from list
// https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118

namespace codewars.com.Kata._8_kyu.Remove_duplicates_from_list
{
    using System.Linq;

    namespace Solution
    {
        public static class Program
        {
            public static int[] distinct(int[] a)
            {
                return a.Distinct().ToArray();
            }
        }
    }
}