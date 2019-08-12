// Leap Years
// https://www.codewars.com/kata/526c7363236867513f0005ca

namespace codewars.com.Kata._8_kyu.Leap_Years
{
    public static class Kata
    {
        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
}