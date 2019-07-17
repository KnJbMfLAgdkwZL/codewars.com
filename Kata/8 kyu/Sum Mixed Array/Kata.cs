// Sum Mixed Array
// https://www.codewars.com/kata/57eaeb9578748ff92a000009

namespace codewars.com.Kata._8_kyu.Sum_Mixed_Array
{
    public class Kata
    {
        public static int SumMix(object[] x)
        {
            var sum = 0;
            foreach (var v in x)
                if (int.TryParse(v.ToString(), out var num))
                    sum += num;
            return sum;

            //return x.Sum(ToInt32);
        }
    }
}