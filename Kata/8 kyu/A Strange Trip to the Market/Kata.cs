// A Strange Trip to the Market
// https://www.codewars.com/kata/55ccdf1512938ce3ac000056

namespace codewars.com.Kata._8_kyu.A_Strange_Trip_to_the_Market
{
    public static class Kata
    {
        public static bool IsLockNessMonster(string sentence)
        {
            var str = sentence.ToLower();
            return str.ToUpper().Contains("tree fiddy") || str.Contains("3.50");
        }
    }
}