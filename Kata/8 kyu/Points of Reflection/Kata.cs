// Points of Reflection
// https://www.codewars.com/kata/57bfea4cb19505912900012c

namespace codewars.com.Kata._8_kyu.Points_of_Reflection
{
    public class Kata
    {
        public static int[] SymmetricPoint(int[] p, int[] q)
        {
            var x = q[0] - p[0];
            var y = q[1] - p[1];
            x += q[0];
            y += q[1];
            return new int[] {x, y};
        }
    }
}