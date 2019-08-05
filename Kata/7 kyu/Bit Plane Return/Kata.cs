// Bit Plane Return
// https://www.codewars.com/kata/5a1a00dcba2a14738a000029

namespace codewars.com.Kata._8_kyu.Bit_Plane_Return
{
    using System;
    using System.Linq;

    public static class Kata
    {
        public static byte[][] BitSlice(byte[][] image, int plane)
        {
            var res = image.Select(r => r.Select(v =>
            {
                var binary = Convert.ToString(v, 2);
                var binaryPad = binary.PadLeft(8, '0');
                var revBinArr = binaryPad.Reverse().ToArray();
                var revStr = new string(revBinArr);
                var bitStr = revStr[plane].ToString();
                return byte.Parse(bitStr);
            }).ToArray());
            return res.ToArray();
        }
    }
}