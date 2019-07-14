// I love you a little  a lot passionately  not at all
// https://www.codewars.com/kata/57f24e6a18e9fad8eb000296

namespace codewars.com.Kata._8_kyu.I_love_you_a_little__a_lot_passionately__not_at_all
{
    public class Kata
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            var arr = new string[]
            {
                "not at all",
                "I love you",
                "a little",
                "a lot",
                "passionately",
                "madly"
            };
            return arr[nb_petals % 6];
        }
    }
}