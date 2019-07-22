// Find the position
// https://www.codewars.com/kata/5808e2006b65bff35500008f

namespace codewars.com.Kata._8_kyu.Find_the_position
{
    public class Kata
    {
        public static string Position(char alphabet)
        {
            const string alp = "abcdefghijklmnopqrstuvwxyz";
            var i = alp.IndexOf(alphabet) + 1;
            return $"Position of alphabet: {i}";
        }
    }
}