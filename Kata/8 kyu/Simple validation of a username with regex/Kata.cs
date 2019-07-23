// Simple validation of a username with regex
// https://www.codewars.com/kata/56a3f08aa9a6cc9b75000023

namespace codewars.com.Kata._8_kyu.Simple_validation_of_a_username_with_regex
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static bool ValidateUsr(string username)
        {
            return Regex.IsMatch(username, "^[a-z0-9_]{4,16}$");
        }
    }
}