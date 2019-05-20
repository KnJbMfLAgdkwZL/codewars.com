// https://www.codewars.com/kata/53da3dbb4a5168369a0000fe
// Even or Odd

namespace Even_or_Odd
{
    using System;

    public static class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}