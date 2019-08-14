// Simple Fun 176 Reverse Letter
// https://www.codewars.com/kata/58b8c94b7df3f116eb00005b

namespace codewars.com.Kata._8_kyu.Simple_Fun_176_Reverse_Letter
{
    using System.Text.RegularExpressions;
    using System.Linq;

    namespace myjinxin
    {
        public class Kata
        {
            public string ReverseLetter(string str)
            {
                var r = str.Where(v => Regex.IsMatch(v.ToString(), @"^[a-zA-Z]+$"));
                return new string(r.Reverse().ToArray());
            }
        }
    }
}