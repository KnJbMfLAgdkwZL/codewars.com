// Find Count of Most Frequent Item in an Array
// https://www.codewars.com/kata/56582133c932d8239900002e

namespace codewars.com.Kata._8_kyu.Find_Count_of_Most_Frequent_Item_in_an_Array
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static int MostFrequentItemCount(int[] collection)
        {
            if (collection.Length == 0)
                return 0;
            var dic = new Dictionary<int, int>();
            foreach (var v in collection)
            {
                if (!dic.ContainsKey(v))
                    dic[v] = 0;
                dic[v]++;
            }

            return dic.Values.Max();
        }
    }
}