// https://www.codewars.com/kata/5259b20d6021e9e14c0010d4
// Reverse words


namespace codewars.com.Kata._7_kyu.Reverse_words
{
    using System.Linq;

    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            var revArr = str.Reverse().ToArray();
            var revStr = new string(revArr);
            var tmp = revStr.Split(' ');
            tmp = tmp.Reverse().ToArray();
            var r = string.Join(" ", tmp);
            return r;
        }
    }
}