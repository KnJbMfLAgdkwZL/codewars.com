// Surface Area and Volume of a Box
// https://www.codewars.com/kata/565f5825379664a26b00007c

namespace codewars.com.Kata._8_kyu.Surface_Area_and_Volume_of_a_Box
{
    public class Kata
    {
        public static int[] Get_size(int w, int h, int d)
        {
            var area = 2 * w * h + 2 * h * d + 2 * w * d;
            var volume = w * h * d;
            return new[] {area, volume};
        }
    }
}