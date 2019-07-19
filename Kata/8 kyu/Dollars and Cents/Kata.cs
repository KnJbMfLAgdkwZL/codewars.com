// Dollars and Cents
// https://www.codewars.com/kata/55902c5eaa8069a5b4000083

namespace codewars.com.Kata._8_kyu.Dollars_and_Cents
{
    using System;

    public class Kata
    {
        public static string FormatMoney(double amount)
        {
            var r = Math.Round(amount, 2).ToString().Split('.');
            if (r.Length == 1)
                return $"${r[0]}.00";
            r[1] = $"{r[1]}00";
            return $"${r[0]}.{r[1].Substring(0, 2)}";
            // return $"${amount:F2}";
        }
    }
}