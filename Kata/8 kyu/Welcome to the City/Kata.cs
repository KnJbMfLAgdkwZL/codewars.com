// Welcome to the City
// https://www.codewars.com/kata/5302d846be2a9189af0001e4

namespace codewars.com.Kata._8_kyu.Welcome_to_the_City
{
    public class Kata
    {
        public static string SayHello(string[] name, string city, string state)
        {
            var n = string.Join(" ", name);
            return $"Hello, {n}! Welcome to {city}, {state}!";
        }
    }
}