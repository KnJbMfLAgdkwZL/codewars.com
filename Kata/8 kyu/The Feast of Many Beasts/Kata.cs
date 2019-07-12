// The Feast of Many Beasts
// https://www.codewars.com/kata/5aa736a455f906981800360d

namespace codewars.com.Kata._8_kyu.The_Feast_of_Many_Beasts
{
    public class Kata
    {
        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
        }
    }
}