// Well of Ideas  Easy Version
// https://www.codewars.com/kata/57f222ce69e09c3630000212

namespace codewars.com.Kata._8_kyu.Well_of_Ideas__Easy_Version
{
    using System.Linq;

    public class Kata
    {
        public static string Well(string[] x)
        {
            var count = x.Count(v => v == "good");
            if (count > 2)
                return "I smell a series!";
            if (count > 0)
                return "Publish!";
            return "Fail!";
        }
    }
}