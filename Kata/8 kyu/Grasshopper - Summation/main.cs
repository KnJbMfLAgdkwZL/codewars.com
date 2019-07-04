// Grasshopper - Summation
// https://www.codewars.com/kata/55d24f55d7dd296eb9000030

namespace Grasshopper_Summation
{
    public static class Kata
    {
        public static int summation(int num)
        {
            var sum = 0;
            for (var i = 1; i <= num; i++)
                sum += i;
            return sum;

            // return num*(num+1)/2;
        }
    }
}