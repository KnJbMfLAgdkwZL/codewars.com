// Will you make it
// https://www.codewars.com/kata/5861d28f124b35723e00005e

namespace codewars.com.Kata._8_kyu.Will_you_make_it
{
    public static class Kata
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return mpg * fuelLeft >= distanceToPump;
        }
    }
}