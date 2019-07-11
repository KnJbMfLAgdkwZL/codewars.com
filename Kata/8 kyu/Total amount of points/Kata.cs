// Total amount of points
// https://www.codewars.com/kata/5bb904724c47249b10000131

namespace codewars.com.Kata._8_kyu.Total_amount_of_points
{
    public static class Kata
    {
        public static int TotalPoints(string[] games)
        {
            var sum = 0;
            foreach (var v in games)
            {
                var t = v.Split(':');
                var x = int.Parse(t[0]);
                var y = int.Parse(t[1]);
                if (x > y)
                    sum += 3;
                if (x < y)
                    sum += 0;
                if (x == y)
                    sum += 1;
            }

            return sum;
        }
    }
}