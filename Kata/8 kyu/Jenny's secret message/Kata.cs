// Jenny's secret message
// https://www.codewars.com/kata/55225023e1be1ec8bc000390

namespace codewars.com.Kata._8_kyu.Jenny_secret_message
{
    public static class Kata
    {
        public static string greet(string name)
        {
            if (name == "Johnny")
                return "Hello, my love!";
            return "Hello, " + name + "!";
        }
    }
}