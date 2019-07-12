// Transportation on vacation
// https://www.codewars.com/kata/568d0dd208ee69389d000016

namespace codewars.com.Kata._8_kyu.Transportation_on_vacation
{
    public class RentalCar
    {
        public static int RentalCarCost(int d)
        {
            var a = 0;
            if (d >= 3)
                a = 20;
            if (d >= 7)
                a = 50;
            return d * 40 - a;
        }
    }
}