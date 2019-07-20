// They say that only the name is long enough to attract attention They also said that only a simple Kata will have someone to solve it This is a sadly story 1 Are they opposite
// https://www.codewars.com/kata/574b1916a3ebd6e4fa0012e7

namespace codewars.com.Kata._8_kyu.
    They_say_that_only_the_name_is_long_enough_to_attract_attention_They_also_said_that_only_a_simple_Kata_will_have_someone_to_solve_it_This_is_a_sadly_story_1_Are_they_opposite
{
    using System.Linq;

    public class Kata
    {
        public static bool IsOpposite(string s1, string s2)
        {
            if (s1.Length != s2.Length || s1.Length == 0 || s2.Length == 0 || s1.ToUpper() != s2.ToUpper())
                return false;
            return !s1.Where((t, i) => t == s2[i]).Any();
        }
    }
}