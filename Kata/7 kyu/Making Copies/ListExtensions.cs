// Making Copies
// https://www.codewars.com/kata/53d2697b7152a5e13d000b82

namespace codewars.com.Kata._7_kyu.Making_Copies
{
    using System.Linq;
    using System.Collections.Generic;

    public static class ListExtensions
    {
        public static List<T> Copy<T>(this List<T> lst)
        {
            return lst.Select(v => v).ToList();
        }
    }
}