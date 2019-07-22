// Add Length
// https://www.codewars.com/kata/559d2284b5bb6799e9000047

namespace codewars.com.Kata._8_kyu.Add_Length
{
    public class Kata
    {
        public static string[] AddLength(string str)
        {
            var words = str.Split(' ');
            for (var i = 0; i < words.Length; i++)
                words[i] = $"{words[i]} {words[i].Length}";
            return words;
        }
    }
}