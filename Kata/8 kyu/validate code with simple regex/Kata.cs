// validate code with simple regex
// https://www.codewars.com/kata/56a25ba95df27b7743000016

namespace codewars.com.Kata._8_kyu.validate_code_with_simple_regex
{
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static bool ValidateCode(string code)
        {
            return Regex.IsMatch(code, "^[123]");
        }
    }
}