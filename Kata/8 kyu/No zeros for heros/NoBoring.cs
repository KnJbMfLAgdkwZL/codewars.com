// No zeros for heros
// https://www.codewars.com/kata/570a6a46455d08ff8d001002

namespace codewars.com.Kata._8_kyu.No_zeros_for_heros
{
    public class NoBoring
    {
        public static int NoBoringZeros(int n)
        {
            var str = n.ToString();
            while (str.Length > 1 && str[str.Length - 1] == '0')
                str = str.Substring(0, str.Length - 1);
            return int.Parse(str);
        }
    }
}