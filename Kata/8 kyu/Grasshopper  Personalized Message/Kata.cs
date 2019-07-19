// Grasshopper  Personalized Message
// https://www.codewars.com/kata/5772da22b89313a4d50012f7

namespace codewars.com.Kata._8_kyu.Grasshopper__Personalized_Message
{
    public class Kata
    {
        public static string Greet(string name, string owner)
        {
            var n = name == owner ? "boss" : "guest";
            return $"Hello {n}";
        }
    }
}