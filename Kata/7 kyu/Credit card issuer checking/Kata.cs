// Credit card issuer checking
// https://www.codewars.com/kata/5701e43f86306a615c001868

namespace codewars.com.Kata._7_kyu.Credit_card_issuer_checking
{
    using System.Linq;

    public static class Kata
    {
        public static string getIssuer(long number)
        {
            var str = number.ToString();
            if (str.Length == 15)
            {
                var mastercard = new int[]
                {
                    34, 37
                };
                if (mastercard.Any(v => str.StartsWith(v.ToString())))
                    return "AMEX";
            }
            else if (str.Length == 16 && str.StartsWith("4"))
            {
                return "VISA";
            }
            else if (str.Length == 16 && str.StartsWith("6011"))
            {
                return "Discover";
            }
            else if (str.Length == 16)
            {
                var mastercard = new int[]
                {
                    51, 52, 53, 54, 55
                };
                if (mastercard.Any(v => str.StartsWith(v.ToString())))
                    return "Mastercard";
            }
            else if (str.Length == 13 && str.StartsWith("4"))
            {
                return "VISA";
            }

            return "Unknown";
        }
    }
}