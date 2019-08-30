// Steer the Ship
// https://www.codewars.com/kata/5a36f95fb6486a3b4300009d

namespace codewars.com.Kata._7_kyu.Steer_the_Ship
{
    using System;

    namespace SteerTheShip
    {
        public static class Kata
        {
            public static string Steer(double x, double y)
            {
                var a = Math.Atan2(x, y) / Math.PI * 180;
                a = Math.Round(a, 2);
                return a >= 0 ? $"R: {a}" : $"L: {-a}";
            }
        }
    }
}