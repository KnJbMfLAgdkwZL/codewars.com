// shorter concat reverse longer
// https://www.codewars.com/kata/54557d61126a00423b000a45

namespace codewars.com.Kata._7_kyu.shorter_concat_reverse_longer
{
    using System.Linq;

    class ReverseLonger
    {
        public static string ShorterReverseLonger(string a, string b)
        {
            if (a == null)
                a = "";
            if (b == null)
                b = "";
            var shr = a.Length < b.Length ? a : b;
            var lng = a.Length >= b.Length ? a : b;
            var rev = new string(lng.Reverse().ToArray());
            return $"{shr}{rev}{shr}";
        }
    }
}