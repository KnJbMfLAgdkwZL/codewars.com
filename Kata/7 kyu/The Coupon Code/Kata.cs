// The Coupon Code
// https://www.codewars.com/kata/539de388a540db7fec000642

namespace codewars.com.Kata._7_kyu.The_Coupon_Code
{
    using System;

    public static class Kata
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate,
            string expirationDate)
        {
            if (enteredCode != correctCode)
                return false;

            if (DateTime.Parse(currentDate) > DateTime.Parse(expirationDate))
                return false;

            return true;
        }
    }
}