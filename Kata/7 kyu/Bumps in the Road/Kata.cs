// Bumps in the Road
// https://www.codewars.com/kata/57ed30dde7728215300005fa

namespace codewars.com.Kata._8_kyu.Bumps_in_the_Road
{
    using System.Linq;

    class Kata
    {
        public static string Bump(string input)
        {
            var cnt = input.Count(v => v == 'n');
            if (cnt >= 15)
                return "Car Dead";
            return "Woohoo!";
        }
    }
}