// Enumerable Magic 3  Does My List Include This
// https://www.codewars.com/kata/545991b4cbae2a5fda000158

namespace codewars.com.Kata._8_kyu.Enumerable_Magic_3__Does_My_List_Include_This
{
    using System.Linq;

    public class Kata
    {
        public static bool Include(int[] arr, int item)
        {
            return arr.Contains(item);
        }
    }
}