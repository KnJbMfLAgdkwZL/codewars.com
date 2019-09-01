// Maximum Product
// https://www.codewars.com/kata/5a4138acf28b82aa43000117

namespace codewars.com.Kata._7_kyu.Maximum_Product
{
    public class Kata
    {
        public static int AdjacentElementsProduct(int[] array)
        {
            var max = array[0] * array[1];
            for (var i = 0; i < array.Length - 1; i++)
            {
                var t = array[i] * array[i + 1];
                if (t > max)
                    max = t;
            }

            return max;
        }
    }
}