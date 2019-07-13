// Correct the mistakes of the character recognition software
// https://www.codewars.com/kata/577bd026df78c19bca0002c0

namespace codewars.com.Kata._8_kyu.Correct_the_mistakes_of_the_character_recognition_software
{
    public class Kata
    {
        public static string Correct(string text)
        {
            text = text.Replace('5', 'S');
            text = text.Replace('0', 'O');
            text = text.Replace('1', 'I');
            return text;
        }
    }
}