// Name Array Capping
// https://www.codewars.com/kata/5356ad2cbb858025d800111d

namespace codewars.com.Kata._7_kyu.Name_Array_Capping
{
    using System.Linq;
    using System.Globalization;

    public static class Kata
    {
        public static string[] CapMe(string[] strings)
        {
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return strings.Select(v => textInfo.ToTitleCase(v.ToLower())).ToArray();
        }
    }
}