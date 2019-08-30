// Insert dashes
// https://www.codewars.com/kata/55960bbb182094bc4800007b

namespace codewars.com.Kata._7_kyu.Insert_dashes
{
    using System.Collections.Generic;

    public class Kata
    {
        public static string InsertDash(int num)
        {
            var res = new List<string>();
            string prev = null;
            foreach (var v in num.ToString())
            {
                if (prev != null)
                    if (int.Parse(prev) % 2 != 0 && int.Parse(v.ToString()) % 2 != 0)
                    {
                        res.Add($"-{v}");
                        continue;
                    }

                res.Add($"{v}");
                prev = v.ToString();
            }

            return string.Join("", res);
        }
    }
}