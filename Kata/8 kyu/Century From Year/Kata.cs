// Century From Year
// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097

namespace codewars.com.Kata._8_kyu.Century_From_Year
{
    public class Kata
    {
        public static int СenturyFromYear(int year)
        {
            var cen = (int) (year / 100);
            if (year % 100 == 0)
                return cen;
            return cen + 1;
        }
    }
}