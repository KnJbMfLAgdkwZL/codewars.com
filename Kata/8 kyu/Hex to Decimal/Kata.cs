// Hex to Decimal
// https://www.codewars.com/kata/57a4d500e298a7952100035d

namespace codewars.com.Kata._8_kyu.Hex_to_Decimal
{
    public class Kata
    {
        public static int HexToDec(string hexString)
        {
            var res = int.Parse(hexString.Replace("-", ""), System.Globalization.NumberStyles.HexNumber);
            if (hexString.Contains("-"))
                return -res;
            return res;
        }
    }
}