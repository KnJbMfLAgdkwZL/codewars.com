// Remove First and Last Character
// https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0

namespace Remove_First_and_Last_Character
{
    public class Kata
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}