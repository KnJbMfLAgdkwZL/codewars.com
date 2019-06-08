// Create Phone Number
// https://www.codewars.com/kata/525f50e3b73515a6db000b83

namespace Create_Phone_Number
{
    using System.Linq;

    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var str1 = string.Join("", numbers.Skip(0).Take(3));
            var str2 = string.Join("", numbers.Skip(3).Take(3));
            var str3 = string.Join("", numbers.Skip(6).Take(4));
            return $"({str1}) {str2}-{str3}";
        }
    }
}