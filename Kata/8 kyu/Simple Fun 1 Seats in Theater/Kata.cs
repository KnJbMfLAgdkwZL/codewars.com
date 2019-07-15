// Simple Fun 1 Seats in Theater
// https://www.codewars.com/kata/588417e576933b0ec9000045

namespace codewars.com.Kata._8_kyu.Simple_Fun_1_Seats_in_Theater
{
    public class Kata
    {
        public static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }
    }
}