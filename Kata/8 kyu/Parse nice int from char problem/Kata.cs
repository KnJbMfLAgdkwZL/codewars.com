// Parse nice int from char problem
// https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1

namespace codewars.com.Kata._8_kyu.Parse_nice_int_from_char_problem
{
    public class Kata
    {
        public static int GetAge(string inputString)
        {
            return int.Parse(inputString[0].ToString());
        }
    }
}