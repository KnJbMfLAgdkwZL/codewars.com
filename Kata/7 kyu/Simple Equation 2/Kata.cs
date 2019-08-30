// Simple Equation 2
// https://www.codewars.com/kata/5641b3f737b248b8840000b0

namespace codewars.com.Kata._7_kyu.Simple_Equation_2
{
    namespace SolveIt
    {
        public class Kata
        {
            public static int result(string stringInput)
            {
                var str = stringInput.Replace(" ", "");
                str = str.Replace("+", " + ");
                str = str.Replace("-", " - ");
                var sum = 0;
                var op = "+";
                var data = str.Split(" ");
                foreach (var v in data)
                    if (int.TryParse(v, out var num))
                    {
                        switch (op)
                        {
                            case "+":
                                sum += num;
                                break;
                            case "-":
                                sum -= num;
                                break;
                        }
                    }
                    else
                        op = v;

                return sum;
            }
        }
    }
}