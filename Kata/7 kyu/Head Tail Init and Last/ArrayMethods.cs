// Head Tail Init and Last
// https://www.codewars.com/kata/54592a5052756d5c5d0009c3

namespace codewars.com.Kata._7_kyu.Head_Tail_Init_and_Last
{
    using System.Linq;
    using System.Collections.Generic;

    public static class ArrayMethods
    {
        public static TSource Head<TSource>(this List<TSource> list)
        {
            return list.First();
        }

        public static List<TSource> Tail<TSource>(this List<TSource> list)
        {
            return list.Skip(1).ToList();
        }

        public static List<TSource> Init<TSource>(this List<TSource> list)
        {
            return list.Take(list.Count - 1).ToList();
        }

        public static TSource Last_<TSource>(this List<TSource> list)
        {
            return list.Last();
        }
    }
}