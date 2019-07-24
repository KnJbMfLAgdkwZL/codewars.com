// Printing Array elements with Comma delimiters
// https://www.codewars.com/kata/56e2f59fb2ed128081001328

namespace codewars.com.Kata._8_kyu.Printing_Array_elements_with_Comma_delimiters
{
    using System;
    using System.Collections.Generic;

    public class Kata
    {
        public static string PrintArray(object[] array)
        {
            var res = new List<object>();
            foreach (var v in array)
                if (v is Array)
                    foreach (var v2 in v as Array)
                        res.Add(v2);
                else
                    res.Add(v);

            return string.Join(",", res);
        }
    }
}