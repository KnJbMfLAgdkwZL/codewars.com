// Fake Binary
// https://www.codewars.com/kata/57eae65a4321032ce000002d

namespace codewars.com.Kata._8_kyu.Fake_Binary
{
    using System.Linq;

    public class Kata
    {
        public static string FakeBin(string x)
        {
            return new string(x.ToCharArray().Select(v => int.Parse(v.ToString()) < 5 ? '0' : '1').ToArray());
        }
    }
}