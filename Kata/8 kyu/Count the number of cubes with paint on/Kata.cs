// Count the number of cubes with paint on
// https://www.codewars.com/kata/5763bb0af716cad8fb000580

namespace codewars.com.Kata._8_kyu.Count_the_number_of_cubes_with_paint_on
{
    public static class Kata
    {
        public static int CountSquares(int cuts)
        {
            if (cuts == 0)
                return 1;
            return 6 * cuts * cuts + 2;
        }
    }
}