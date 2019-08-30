// Reverse a Number
// https://www.codewars.com/kata/555bfd6f9f9f52680f0000c5

namespace codewars.com.Kata._7_kyu.Reverse_a_Number
{
    using System.Linq;

    public class Kata
    {
        public int ReverseNumber(int n)
        {
            var arr = n.ToString().Replace("-", "").Reverse().ToArray();
            var str = new string(arr);
            var res = int.Parse(str);
            return n < 0 ? -res : res;
        }
    }
}