// Lario and Muigi Pipe Problem
// https://www.codewars.com/kata/56b29582461215098d00000f

namespace codewars.com.Kata._8_kyu.Lario_and_Muigi_Pipe_Problem
{
    using System.Collections.Generic;
    using System.Linq;

    public class Fixer
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            return Enumerable.Range(numbers.Min(), numbers.Max() - numbers.Min() + 1).ToList();
        }
    }
}