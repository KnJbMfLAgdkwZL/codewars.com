// Name Shuffler
// https://www.codewars.com/kata/559ac78160f0be07c200005a

namespace codewars.com.Kata._8_kyu.Name_Shuffler
{
    using System.Linq;

    public class Kata
    {
        public static string NameShuffler(string str)
        {
            return string.Join(" ", str.Split(" ").Reverse());
        }
    }
}