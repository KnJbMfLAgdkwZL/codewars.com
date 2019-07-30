// SwitchCase  Bug Fixing 6
// https://www.codewars.com/kata/55c933c115a8c426ac000082

namespace codewars.com.Kata._8_kyu.SwitchCase__Bug_Fixing_6
{
    using System;

    public class Kata
    {
        public static double EvalObject(double value1, double value2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '%':
                    result = value1 % value2;
                    break;
                case '^':
                    result = Math.Pow(value1, value2);
                    break;
            }

            return result;
        }
    }
}