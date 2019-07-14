// Get the mean of an array
// https://www.codewars.com/kata/563e320cee5dddcf77000158

namespace codewars.com.Kata._8_kyu.Get_the_mean_of_an_array
{
    using System.Linq;

    public class Kata
    {
        public static int GetAverage(int[] marks)
        {
            return (int) marks.Average();
        }
    }
}