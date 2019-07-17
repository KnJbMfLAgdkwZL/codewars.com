// Training JS 7 ifelse and ternary operator
// https://www.codewars.com/kata/57202aefe8d6c514300001fd

namespace codewars.com.Kata._8_kyu.Training_JS_7_ifelse_and_ternary_operator
{
    public class Kata
    {
        public static int SaleHotDogs(int n)
        {
            var p = 100;
            if (n >= 5 && n < 10)
                p = 95;
            if (n >= 10)
                p = 90;
            return n * p;
        }
    }
}