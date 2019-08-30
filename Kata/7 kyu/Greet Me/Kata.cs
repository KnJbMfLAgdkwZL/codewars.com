// Greet Me
// https://www.codewars.com/kata/535474308bb336c9980006f2

namespace codewars.com.Kata._7_kyu.Greet_Me
{
    using System.Globalization;

    public static class Kata
    {
        public static string Greet(string name)
        {
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            name = textInfo.ToTitleCase(name.ToLower());
            return $"Hello {name}!";
        }
    }
}