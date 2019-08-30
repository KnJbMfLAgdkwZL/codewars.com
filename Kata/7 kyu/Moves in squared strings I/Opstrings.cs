// Moves in squared strings I
// https://www.codewars.com/kata/56dbe0e313c2f63be4000b25

namespace codewars.com.Kata._7_kyu.Moves_in_squared_strings_I
{
    using System.Linq;

    public class Opstrings
    {
        public static string VertMirror(string strng)
        {
            var spl = strng.Split('\n');
            var res = spl.Select(v => new string(v.Reverse().ToArray()));
            return string.Join('\n', res);
        }

        public static string HorMirror(string strng)
        {
            var spl = strng.Split('\n');
            var res = spl.Reverse().ToArray();
            return string.Join('\n', res);
        }

        public delegate string MyDelegate(string values);

        public static string Oper(MyDelegate fct, string s)
        {
            return fct(s);
        }
    }
}