// Deodorant Evaporator
// https://www.codewars.com/kata/5506b230a11c0aeab3000c1f

namespace codewars.com.Kata._7_kyu.Deodorant_Evaporator
{
    public class Evaporator
    {
        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            var i = 0;
            var thr = content / 100 * threshold;
            do
            {
                i++;
                content -= (content / 100 * evap_per_day);
                if (content < thr)
                    break;
            } while (true);

            return i;
        }
    }
}