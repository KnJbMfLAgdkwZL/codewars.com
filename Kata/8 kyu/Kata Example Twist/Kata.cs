// Kata Example Twist
// https://www.codewars.com/kata/525c1a07bb6dda6944000031

namespace codewars.com.Kata._8_kyu.Kata_Example_Twist
{
    public static class Kata
    {
        public static string[] Websites;

        static Kata()
        {
            Websites = new string[1000];
            for (var i = 0; i < Websites.Length; i++)
                Websites[i] = "codewars";
        }
    }
}