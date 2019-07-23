// simple calculator
// https://www.codewars.com/kata/5810085c533d69f4980001cf

namespace codewars.com.Kata._8_kyu.simple_calculator
{
    public class Kata
    {
        public static double Calculator(double a, double b, char op)
        {
            if (op == '+')
                return a + b;
            else if (op == '-')
                return a - b;
            else if (op == '/')
                return a / b;
            else if (op == '*')
                return a * b;
            throw new System.ArgumentException();
        }
    }
}