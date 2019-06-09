// Which are in?
// https://www.codewars.com/kata/550554fd08b86f84fe000a58

namespace Which_are_in
{
    using System.Linq;

    class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return (from v2 in array2 from v1 in array1 where v2.Contains(v1) orderby v1 select v1).Distinct()
                .ToArray();
        }
    }
}