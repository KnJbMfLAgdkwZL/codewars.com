// All unique
// https://www.codewars.com/kata/553e8b195b853c6db4000048

namespace codewars.com.Kata._7_kyu.All_unique
{
    using System.Linq;

    namespace Code
    {
        public class Unique
        {
            public static bool HasUniqueChars(string str)
            {
                return str == new string(str.Distinct().ToArray());
            }
        }
    }
}