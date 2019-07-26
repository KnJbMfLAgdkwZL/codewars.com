// The falling speed of petals
// https://www.codewars.com/kata/5a0be7ea8ba914fc9c00006b

namespace codewars.com.Kata._8_kyu.The_falling_speed_of_petals
{
    public static class Kata
    {
        public static double SakuraFall(double v)
        {
            if (v <= 0)
                return 0;
            const double s = 400;
            double t = s / v;
            return t;
        }
    }
}