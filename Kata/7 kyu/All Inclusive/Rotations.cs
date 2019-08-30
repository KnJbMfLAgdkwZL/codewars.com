// All Inclusive
// https://www.codewars.com/kata/5700c9acc1555755be00027e

namespace codewars.com.Kata._7_kyu.All_Inclusive
{
    using System;
    using System.Collections.Generic;

    public class Rotations
    {
        public static Boolean ContainAllRots(string strng, List<string> arr)
        {
            if (strng == "")
                return true;
            var v = strng;
            for (var i = 0; i < strng.Length; i++)
            {
                var s1 = v.Substring(v.Length - 1, 1);
                var s2 = v.Substring(0, v.Length - 1);
                v = s1 + s2;
                if (!arr.Contains(v))
                    return false;
            }

            return true;
        }
    }
}