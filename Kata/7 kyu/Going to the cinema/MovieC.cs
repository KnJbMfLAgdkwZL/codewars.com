// Going to the cinema
// https://www.codewars.com/kata/562f91ff6a8b77dfe900006e

namespace codewars.com.Kata._7_kyu.Going_to_the_cinema
{
    using System;

    public class MovieC
    {
        public static int Movie(int card, int ticket, double perc)
        {
            var a = 0;
            double b = card;
            var times = 0;
            while (Math.Ceiling(b) >= a)
            {
                a += ticket;
                b += ticket * Math.Pow(perc, ++times);
            }

            return times;
        }
    }
}