// Tip Calculator
// https://www.codewars.com/kata/56598d8076ee7a0759000087

namespace codewars.com.Kata._8_kyu.Tip_Calculator
{
    public class Kata
    {
        public static int CalculateTip(double amount, string rating)
        {
            double p = 0;
            switch (rating.ToLower())
            {
                case "terrible":
                    p = 0 / 100.0;
                    break;
                case "poor":
                    p = 5 / 100.0;
                    break;
                case "good":
                    p = 10 / 100.0;
                    break;
                case "great":
                    p = 15 / 100.0;
                    break;
                case "excellent":
                    p = 20 / 100.0;
                    break;
                default:
                    return -1;
            }

            var r = amount * p;
            if (r != (int) r)
                r = 1 + (int) r;
            return (int) r;
        }
    }
}