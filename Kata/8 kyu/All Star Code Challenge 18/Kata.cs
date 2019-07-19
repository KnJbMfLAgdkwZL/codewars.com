// All Star Code Challenge 18
// https://www.codewars.com/kata/5865918c6b569962950002a1

namespace codewars.com.Kata._8_kyu.All_Star_Code_Challenge_18
{
    using System.Linq;

    class Kata
    {
        public static int StrCount(string str, string letter)
        {
            return str.Count(v => v.ToString() == letter);
        }
    }
}