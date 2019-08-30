// Sorted yes no how
// https://www.codewars.com/kata/580a4734d6df748060000045

namespace codewars.com.Kata._7_kyu.Sorted_yes_no_how
{
    using System.Linq;

    public class Kata
    {
        public static string IsSortedAndHow(int[] array)
        {
            var des = string.Join("", array.OrderByDescending(v => v));
            var asc = string.Join("", array.OrderBy(v => v));
            var cur = string.Join("", array);
            if (cur == des)
                return "yes, descending";
            if (cur == asc)
                return "yes, ascending";
            return "no";
        }
    }
}