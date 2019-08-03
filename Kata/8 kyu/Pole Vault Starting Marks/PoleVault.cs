// Pole Vault Starting Marks
// https://www.codewars.com/kata/5786f8404c4709148f0006bf

namespace codewars.com.Kata._8_kyu.Pole_Vault_Starting_Marks
{
    using System;

    class PoleVault
    {
        public static double StartingMark(double bodyHeight)
        {
            var r = bodyHeight - 1.22;
            return Math.Round(r * 100 * 0.0393 + 8.27, 2);
        }
    }

    class PoleVault1
    {
        public static double StartingMark(double bodyHeight)
        {
            return Math.Round(m * bodyHeight + b.Item2 - m * b.Item1, 2);
        }

        static readonly Tuple<double, double> a = Tuple.Create(1.52, 9.45);
        static readonly Tuple<double, double> b = Tuple.Create(1.83, 10.67);
        static readonly double m = (b.Item2 - a.Item2) / (b.Item1 - a.Item1);
    }

    class PoleVault2
    {
        public static double StartingMark(double bodyHeight)
        {
            double delta = (11.85 - 8.27) / (2.13 - 1.22);
            return Math.Round(11.85 - (2.13 - bodyHeight) * delta, 2);
        }
    }
}