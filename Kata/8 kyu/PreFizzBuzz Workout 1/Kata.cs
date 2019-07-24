// PreFizzBuzz Workout 1
// https://www.codewars.com/kata/569e09850a8e371ab200000b

namespace codewars.com.Kata._8_kyu.PreFizzBuzz_Workout_1
{
    using System.Linq;

    public class Kata
    {
        public static int[] PreFizz(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}