// String Calculator
// https://www.codewars.com/kata/55ffd58d186cc9394f0000cc

namespace codewars.com.Kata._7_kyu.String_Calculator
{
    using System.Linq;

    public static class Kata
    {
        public static int AddStrings(string numbers)
        {
            var str = numbers.Replace(",", "");
            var num = str.Split(" ");
            return num.Sum(int.Parse);
        }
    }
}