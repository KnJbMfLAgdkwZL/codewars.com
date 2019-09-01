// How many arguments
// https://www.codewars.com/kata/5c44b0b200ce187106452139

namespace codewars.com.Kata._7_kyu.How_many_arguments
{
    public static class Kata
    {
        public static int CountArgs(params object[] numbers)
        {
            return numbers.Length;
        }
    }
}