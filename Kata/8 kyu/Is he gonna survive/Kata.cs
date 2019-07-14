// Is he gonna survive
// https://www.codewars.com/kata/59ca8246d751df55cc00014c

namespace codewars.com.Kata._8_kyu.Is_he_gonna_survive
{
    class Kata
    {
        public static bool Hero(int bullets, int dragons)
        {
            return (int) (bullets / 2) >= dragons;
        }
    }
}