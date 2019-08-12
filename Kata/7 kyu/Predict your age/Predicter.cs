// Predict your age
// https://www.codewars.com/kata/5aff237c578a14752d0035ae

namespace codewars.com.Kata._8_kyu.Predict_your_age
{
    using System;
    using System.Linq;

    public class Predicter
    {
        public static int PredictAge(params int[] infiniteArgs)
        {
            return (int) Math.Sqrt(infiniteArgs.Select(v => Math.Pow(v, 2)).Sum()) / 2;
        }
    }
}