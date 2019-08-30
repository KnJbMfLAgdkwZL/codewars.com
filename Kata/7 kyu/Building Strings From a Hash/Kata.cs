// Building Strings From a Hash
// https://www.codewars.com/kata/51c7d8268a35b6b8b40002f2

namespace codewars.com.Kata._7_kyu.Building_Strings_From_a_Hash
{
    using System.Linq;
    using System.Collections.Generic;

    public static class Kata
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            var r = hash.Select(v => $"{v.Key} = {v.Value}");
            return string.Join(",", r);
        }
    }
}