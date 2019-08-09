// Caffeine Script
// https://www.codewars.com/kata/5434283682b0fdb0420000e6

namespace codewars.com.Kata._8_kyu.Caffeine_Script
{
    public class Kata
    {
        public static string CaffeineBuzz(int n)
        {
            string str = "mocha_missing!";
            if (n % 3 == 0)
            {
                if (n % 3 == 0)
                    str = "Java";
                if (n % 3 == 0 && n % 4 == 0)
                    str = "Coffee";
                if (n % 2 == 0)
                    str += "Script";
            }

            return str;
        }
    }
}