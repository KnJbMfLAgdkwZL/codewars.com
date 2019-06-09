// Write Number in Expanded Form
// https://www.codewars.com/kata/5842df8ccbd22792a4000245

namespace Write_Number_in_Expanded_Form
{
    using System;
    using System.Collections.Generic;

    public static class Kata
    {
        public static string ExpandedForm(long num)
        {
            var res = new List<string>();
            var str = num.ToString();
            var i = 0;
            foreach (var v in str)
            {
                i++;
                if (v != '0')
                    res.Add(v + new String('0', str.Length - i));
            }

            return string.Join(" + ", res);
        }
    }
}