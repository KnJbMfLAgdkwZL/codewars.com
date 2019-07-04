// Basic Mathematical Operations
// https://www.codewars.com/kata/57356c55867b9b7a60000bd7

namespace Basic_Mathematical_Operations
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            if (operation == '+')
                return value1 + value2;
            if (operation == '-')
                return value1 - value2;
            if (operation == '*')
                return value1 * value2;
            if (operation == '/')
                return value1 / value2;
            return 0;
        }
    }
}