// Are You Playing Banjo
// https://www.codewars.com/kata/53af2b8861023f1d88000832

namespace codewars.com.Kata._8_kyu.Are_You_Playing_Banjo
{
    public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            return (name.ToUpper()[0] == 'R') ? $"{name} plays banjo" : $"{name} does not play banjo";
        }
    }
}