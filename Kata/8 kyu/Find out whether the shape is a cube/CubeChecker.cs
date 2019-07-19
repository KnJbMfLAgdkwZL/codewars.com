// Find out whether the shape is a cube
// https://www.codewars.com/kata/58d248c7012397a81800005c

namespace codewars.com.Kata._8_kyu.Find_out_whether_the_shape_is_a_cube
{
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            if (volume <= 0 || side <= 0)
                return false;
            return side * side * side == volume;
        }
    }
}