// Logical calculator
// https://www.codewars.com/kata/57096af70dad013aa200007b

namespace codewars.com.Kata._8_kyu.Logical_calculator
{
    using System.Linq;

    public class Kata
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            if (op == "AND")
                return !array.Contains(false);
            if (op == "OR")
                return array.Contains(true);
            if (op == "XOR")
                if (array.Count(v => v == true) % 2 != 0)
                    return true;
            return false;
        }
    }
}