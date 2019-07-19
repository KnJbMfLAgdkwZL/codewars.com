// Is this my tail
// https://www.codewars.com/kata/56f695399400f5d9ef000af5

namespace codewars.com.Kata._8_kyu.Is_this_my_tail
{
    using System.Linq;

    public class Kata
    {
        public static bool CorrectTail(string body, string tail)
        {
            return body.Last().ToString() == tail;
        }
    }
}