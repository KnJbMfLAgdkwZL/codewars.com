// My head is at the wrong end
// https://www.codewars.com/kata/56f699cd9400f5b7d8000b55

namespace codewars.com.Kata._8_kyu.My_head_is_at_the_wrong_end
{
    using System.Linq;

    public class Kata
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            return arr.Reverse().ToArray();
        }
    }
}