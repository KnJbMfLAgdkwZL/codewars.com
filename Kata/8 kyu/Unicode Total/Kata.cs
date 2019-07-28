// Unicode Total
// https://www.codewars.com/kata/572b6b2772a38bc1e700007a

namespace codewars.com.Kata._8_kyu.Unicode_Total
{
    using System.Linq;

    public class Kata
    {
        public static int UniTotal(string str)
        {
            return str.ToArray().Sum(v => v);
        }
    }
}