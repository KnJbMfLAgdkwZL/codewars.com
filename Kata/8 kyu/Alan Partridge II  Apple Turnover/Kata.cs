// Alan Partridge II  Apple Turnover
// https://www.codewars.com/kata/580a094553bd9ec5d800007d

namespace codewars.com.Kata._8_kyu.Alan_Partridge_II__Apple_Turnover
{
    public class Kata
    {
        public static string Apple(object n)
        {
            var r = int.Parse(n.ToString());
            if (r * r > 1000)
                return "It's hotter than the sun!!";
            return "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}