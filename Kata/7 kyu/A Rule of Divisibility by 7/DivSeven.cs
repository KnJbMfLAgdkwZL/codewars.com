// A Rule of Divisibility by 7
// https://www.codewars.com/kata/55e6f5e58f7817808e00002e

namespace codewars.com.Kata._8_kyu.A_Rule_of_Divisibility_by_7
{
    using System.Linq;

    public class DivSeven
    {
        public static long[] Seven(long m)
        {
            if (m == 0)
                return new long[] {0, 0};
            var i = 1;
            while (true)
            {
                var str = m.ToString();
                var arr = str.Take(str.Length - 1).ToArray();
                var prev = new string(arr);
                var last = str.Last().ToString();
                var a = long.Parse(prev);
                var b = long.Parse(last);
                var t = a - b * 2;
                if (t.ToString().Length <= 2)
                    return new long[] {t, i};
                m = t;
                i++;
            }
        }
    }
}