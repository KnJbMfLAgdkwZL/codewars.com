// Parts of a list
// https://www.codewars.com/kata/56f3a1e899b386da78000732

namespace codewars.com.Kata._8_kyu.Parts_of_a_list
{
    using System.Collections.Generic;
    using System.Linq;

    public class PartList
    {
        public static string[][] Partlist(string[] arr)
        {
            var res = new List<string[]>();
            for (int i = 1; i < arr.Length; i++)
            {
                var tail = arr.Take(i);
                var head = arr.Skip(i);
                var str0 = string.Join(" ", tail);
                var str1 = string.Join(" ", head);
                res.Add(new string[] {str0, str1});
            }

            return res.ToArray();
        }
    }
}