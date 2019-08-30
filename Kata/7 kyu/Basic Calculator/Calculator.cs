// Basic Calculator
// https://www.codewars.com/kata/5296455e4fe0cdf2e000059f

namespace codewars.com.Kata._7_kyu.Basic_Calculator
{
    using System;

    public static class Calculator
    {
        public static double Execute(double num1, char op, double num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                        throw new ArgumentException();
                    return num1 / num2;
                default:
                    throw new ArgumentException();
            }
        }
    }
}