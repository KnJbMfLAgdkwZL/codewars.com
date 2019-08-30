// Palindrome chain length
// https://www.codewars.com/kata/525f039017c7cd0e1a000a26

namespace codewars.com.Kata._7_kyu.Palindrome_chain_length
{
    using System.Linq;

    public static class Kata
    {
        public static int palindromeChainLength(int n)
        {
            var num = (ulong) n;
            var i = 0;
            do
            {
                var nstr = num.ToString();
                var revstr = new string(nstr.Reverse().ToArray());
                if (nstr != revstr)
                    num = ulong.Parse(nstr) + ulong.Parse(revstr);
                else
                    break;
                i++;
            } while (true);

            return i;
        }
    }
}