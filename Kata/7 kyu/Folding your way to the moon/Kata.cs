// Folding your way to the moon
// https://www.codewars.com/kata/58f0ba42e89aa6158400000e

namespace codewars.com.Kata._7_kyu.Folding_your_way_to_the_moon
{
    public class Kata
    {
        public static int? FoldTo(double distance)
        {
            if (distance < 0)
                return null;
            double cur = 0.0001;
            var i = 0;
            while (cur < distance)
            {
                cur *= 2;
                i++;
            }

            return i;
        }
    }
}