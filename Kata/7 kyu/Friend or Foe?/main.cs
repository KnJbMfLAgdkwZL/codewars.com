// https://www.codewars.com/kata/55b42574ff091733d900002f
// Friend or Foe?

namespace Friend_or_Foe
{
    using System.Linq;
    using System.Collections.Generic;

    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(v => v.Length <= 4).ToList();
        }
    }
}