// Row Weights
// https://www.codewars.com/kata/5abd66a5ccfd1130b30000a9

namespace codewars.com.Kata._7_kyu.Row_Weights
{
    class Kata
    {
        public static int[] RowWeights(int[] a)
        {
            var t1 = 0;
            var t2 = 0;
            for (var i = 0; i < a.Length; i++)
                if (i % 2 == 0)
                    t1 += a[i];
                else
                    t2 += a[i];
            return new[] {t1, t2};
        }
    }
}