// Fuel Calculator
// https://www.codewars.com/kata/57b58827d2a31c57720012e8

namespace codewars.com.Kata._8_kyu.Fuel_Calculator
{
    using System;

    public class Kata
    {
        public static double FuelPrice(double litres, double pricePerLiter)
        {
            var s = (int) litres / 2;
            var dis = s * 0.05;
            if (dis >= 0.25)
                dis = 0.25;
            var res = litres * (pricePerLiter - dis);
            return Math.Round(res, 2);
        }
    }
}