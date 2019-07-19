// Super Duper Easy
// https://www.codewars.com/kata/55a5bfaa756cfede78000026

namespace codewars.com.Kata._8_kyu.Super_Duper_Easy
{
    public class Kata
    {
        public static string Problem(string a)
        {
            if (double.TryParse(a, out var number))
                return number * 50 + 6 + "";
            return "Error";
        }
    }
}