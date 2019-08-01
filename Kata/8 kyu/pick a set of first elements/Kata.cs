// pick a set of first elements
// https://www.codewars.com/kata/572b77262bedd351e9000076

namespace codewars.com.Kata._8_kyu.pick_a_set_of_first_elements
{
    using System.Collections.Generic;

    public class Kata
    {
        public static object[] TakeFirstElements(object[] array, int n = 1)
        {
            if (n == 0)
                return new object[0];
            var res = new List<object>();
            var size = array.Length > n ? n : array.Length;
            for (var i = 0; i < size; i++)
                res.Add(array[i]);
            return res.ToArray();
        }
    }
}