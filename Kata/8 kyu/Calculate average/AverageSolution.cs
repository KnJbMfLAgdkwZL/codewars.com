// Calculate average
// https://www.codewars.com/kata/57a2013acf1fa5bfc4000921

namespace codewars.com.Kata._8_kyu.Calculate_average
{
    using System.Linq;

    public class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0)
                return 0;
            return array.Sum() / array.Length;
        }
    }
}