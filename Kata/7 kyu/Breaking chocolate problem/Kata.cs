// Breaking chocolate problem
// https://www.codewars.com/kata/534ea96ebb17181947000ada

namespace codewars.com.Kata._8_kyu.Breaking_chocolate_problem
{
    public class Kata
    {
        public static int BreakChocolate(int n, int m)
        {
            var squares = n * m - 1;
            if (squares < 0)
                squares = 0;
            return squares;
        }
    }
}