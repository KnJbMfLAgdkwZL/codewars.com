// Find the nth Digit of a Number
// https://www.codewars.com/kata/577b9960df78c19bca00007e

namespace codewars.com.Kata._7_kyu.Find_the_nth_Digit_of_a_Number
{
    public class Kata
    {
        public static int FindDigit(int num, int nth)
        {
            if (nth <= 0)
                return -1;
            var str = num.ToString();
            if (str.Length < nth)
                return 0;
            var r = str[str.Length - nth];
            return r == '-' ? 0 : int.Parse(r.ToString());
        }
    }
}