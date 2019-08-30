// Make a function that does arithmetic
// https://www.codewars.com/kata/583f158ea20cfcbeb400000a

namespace codewars.com.Kata._7_kyu.Make_a_function_that_does_arithmetic
{
    public class Kata
    {
        public static double Arithmetic(double a, double b, string op)
        {
            if (op == "add")
                return a + b;
            if (op == "subtract")
                return a - b;
            if (op == "multiply")
                return a * b;
            if (op == "divide")
                return a / b;
            return 0;
        }
    }
}