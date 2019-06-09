// Count the smiley faces!
// https://www.codewars.com/kata/583203e6eb35d7980400002a

namespace Count_the_smiley_faces
{
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class Kata
    {
        public static int CountSmileys(string[] smileys)
        {
            const string pattern = @"(:|;)(-|~)*(\)|D)";
            return smileys.Count(v => Regex.IsMatch(v, pattern, RegexOptions.IgnoreCase));
        }
    }
}