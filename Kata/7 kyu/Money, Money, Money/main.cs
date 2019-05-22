// https://www.codewars.com/kata/563f037412e5ada593000114
// Money, Money, Money

namespace Money_Money_Money
{
    public class Kata
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            var years = 0;
            while (principal < desiredPrincipal)
            {
                var income = principal * interest;
                income -= income * tax;
                principal += income;
                years++;
            }

            return years;
        }
    }
}