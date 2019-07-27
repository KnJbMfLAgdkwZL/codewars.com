// Parse float
// https://www.codewars.com/kata/57a386117cb1f31890000039

namespace codewars.com.Kata._8_kyu.Parse_float
{
    public class Kata
    {
        public static double? ParseF(object s = null)
        {
            if (s != null && double.TryParse(s.ToString(), out var res))
                return res;
            return null;
        }
    }
}