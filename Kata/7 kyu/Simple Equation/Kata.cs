// Simple Equation
// https://www.codewars.com/kata/563fd46f2a1863685f000052

namespace codewars.com.Kata._7_kyu.Simple_Equation
{
    namespace Equation
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;

        public class Kata
        {
            public static string SolveTheEquation(string equation)
            {
                var data = equation.Split(" ").Select(v => v.Trim()).ToArray();
                var num = new List<double>();
                foreach (var v in data)
                    if (double.TryParse(v, out var res))
                        num.Add(res);
                var a = num.First();
                var b = num.Last();
                switch (data[1])
                {
                    case "+":
                        return $"x = {b - a}";
                    case "-":
                        return $"x = {b + a}";
                    case "/":
                        return $"x = {b * a}";
                    case "*":
                        return $"x = {Math.Round(b / a, 2)}";
                }

                return "";
            }
        }
    }
}