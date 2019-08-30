// Anagram Detection
// https://www.codewars.com/kata/529eef7a9194e0cbc1000255

namespace codewars.com.Kata._7_kyu.Anagram_Detection
{
    using System.Linq;

    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            if (test.Length != original.Length)
                return false;
            return string.Concat(test.ToLower().OrderBy(v => v)) == string.Concat(original.ToLower().OrderBy(v => v));
        }
    }
}