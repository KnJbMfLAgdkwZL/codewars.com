// Counting sheep...
// https://www.codewars.com/kata/54edbc7200b811e956000556

namespace Counting_sheep
{
    using System.Linq;

    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(v => v);
        }
    }
}