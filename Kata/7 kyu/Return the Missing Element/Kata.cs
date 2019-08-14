// Return the Missing Element
// https://www.codewars.com/kata/5299413901337c637e000004

namespace codewars.com.Kata._8_kyu.Return_the_Missing_Element
{
    using System.Linq;

    public static class Kata
    {
        public static int GetMissingElement(int[] superImportantArray)
        {
            var sorted = superImportantArray.OrderBy(v => v).ToArray();
            for (int i = 0; i < 9; i++)
            {
                if (sorted[i] != i)
                    return i;
            }

            return 9;
        }
    }
}