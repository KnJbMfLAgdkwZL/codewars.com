// Pirates Are the Cannons ready
// https://www.codewars.com/kata/5748a883eb737cab000022a6

namespace codewars.com.Kata._8_kyu.Pirates_Are_the_Cannons_ready
{
    using System.Collections.Generic;

    public static class Kata
    {
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            foreach (var v in gunners)
                if (v.Value != "aye")
                    return "Shiver me timbers!";
            return "Fire!";
        }
    }
}