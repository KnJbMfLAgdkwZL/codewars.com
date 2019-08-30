// Javascript filter  1
// https://www.codewars.com/kata/525d9b1a037b7a9da7000905

namespace codewars.com.Kata._7_kyu.Javascript_filter__1
{
    using System.Linq;

    public class Kata
    {
        public static string[][] search_names(string[][] logins)
        {
            return logins.Where(v => v[0][v[0].Length - 1] == '_').ToArray();
        }
    }
}