// Form The Largest
// https://www.codewars.com/kata/5a4ea304b3bfa89a9900008e

namespace codewars.com.Kata._8_kyu.Form_The_Largest
{
    using System.Linq;

    class Kata
    {
        public static int MaxNumber(int n)
        {
            var str = n.ToString().OrderByDescending(v => v).ToArray();
            return int.Parse(str);
        }
    }
}