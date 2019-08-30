// Boiled Eggs
// https://www.codewars.com/kata/52b5247074ea613a09000164

namespace codewars.com.Kata._7_kyu.Boiled_Eggs
{
    public class Kata
    {
        public static int CookingTime(int eggs)
        {
            var cooking = (int) (eggs / 8.0);
            if (eggs % 8 != 0)
                cooking++;
            return cooking * 5;
        }
    }
}