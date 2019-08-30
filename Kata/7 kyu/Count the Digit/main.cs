// https://www.codewars.com/kata/566fc12495810954b1000030
// Count the Digit

namespace codewars.com.Kata._7_kyu.Count_the_Digit
{
    using System.Text.RegularExpressions;

    public class CountDig
    {
        public static int NbDig(int n, int d)
        {
            var str = d.ToString();
            var count = 0;
            for (var k = 0; k <= n; k++)
            {
                var num = k * k;
                count += Regex.Matches(num.ToString(), str).Count;
            }

            return count;
        }
    }
}