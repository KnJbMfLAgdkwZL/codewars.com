// Partial Word Searching
// https://www.codewars.com/kata/54b81566cd7f51408300022d

namespace codewars.com.Kata._7_kyu.Partial_Word_Searching
{
    using System.Linq;

    public class Kata
    {
        public static string[] WordSearch(string query, string[] seq)
        {
            var res = seq.Where(v => v.ToLower().Contains(query.ToLower())).ToArray();
            return res.Length > 0 ? res : new[] {"Empty"};
        }
    }
}