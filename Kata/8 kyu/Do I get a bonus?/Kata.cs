// Do I get bonus
// https://www.codewars.com/kata/56f6ad906b88de513f000d96

namespace codewars.com.Kata._8_kyu.Do_I_get_bonus
{
    public class Kata
    {
        public static string bonus_time(int salary, bool bonus)
        {
            if (bonus)
                salary *= 10;
            return $"${salary}";
        }
    }
}