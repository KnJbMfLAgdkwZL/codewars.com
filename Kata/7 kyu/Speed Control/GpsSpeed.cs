// Speed Control
// https://www.codewars.com/kata/56484848ba95170a8000004d

namespace codewars.com.Kata._7_kyu.Speed_Control
{
    using System.Collections.Generic;
    using System.Linq;

    public class GpsSpeed
    {
        public static int Gps(int s, double[] x)
        {
            var res = new List<double>();
            double prev = 0;
            res.Add(prev);
            foreach (var v in x)
            {
                var deltaDistance = v - prev;
                var t = (3600 * deltaDistance) / s;
                res.Add(t);
                prev = v;
            }

            return (int) res.Max();
        }
    }
}