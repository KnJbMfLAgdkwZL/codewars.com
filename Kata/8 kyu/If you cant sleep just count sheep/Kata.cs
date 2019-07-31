// If you cant sleep just count sheep
// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077

namespace codewars.com.Kata._8_kyu.If_you_cant_sleep_just_count_sheep
{
    using System.Linq;

    public static class Kata
    {
        public static string CountSheep(int n)
        {
            var r = Enumerable.Range(1, n).Select(v => $"{v} sheep...");
            return string.Join("", r);
        }
    }
}