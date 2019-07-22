// Holiday VIII  Duty Free
// https://www.codewars.com/kata/57e92e91b63b6cbac20001e5

namespace codewars.com.Kata._8_kyu.Holiday_VIII__Duty_Free
{
    public class Kata
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            return (int) (hol / (normPrice * Discount / 100.0));
        }
    }
}