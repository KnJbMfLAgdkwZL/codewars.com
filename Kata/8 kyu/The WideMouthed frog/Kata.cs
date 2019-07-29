// The WideMouthed frog
// https://www.codewars.com/kata/57ec8bd8f670e9a47a000f89

namespace codewars.com.Kata._8_kyu.The_WideMouthed_frog
{
    public class Kata
    {
        public static string MouthSize(string animal)
        {
            if (animal.ToLower() == "alligator")
                return "small";
            return "wide";
        }
    }
}