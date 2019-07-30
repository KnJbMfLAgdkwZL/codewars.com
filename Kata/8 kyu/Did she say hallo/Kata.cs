// Did she say hallo
// https://www.codewars.com/kata/56a4addbfd4a55694100001f

namespace codewars.com.Kata._8_kyu.Did_she_say_hallo
{
    using System.Linq;

    public class Kata
    {
        public static bool Validate_hello(string greetings)
        {
            var arr = new[]
            {
                "hello",
                "ciao",
                "salut",
                "hallo",
                "hola",
                "ahoj",
                "czesc"
            };
            return arr.Any(greetings.ToLower().Contains);
        }
    }
}