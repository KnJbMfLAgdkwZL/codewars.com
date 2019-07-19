// Reverse List Order
// https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b

namespace codewars.com.Kata._8_kyu.Reverse_List_Order
{
    using System.Collections.Generic;

    public class Kata
    {
        public static List<int> ReverseList(List<int> list)
        {
            var res = new List<int>(list);
            res.Reverse();
            return res;
        }
    }
}