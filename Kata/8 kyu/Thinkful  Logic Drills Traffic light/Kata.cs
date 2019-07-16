// Thinkful  Logic Drills Traffic light
// https://www.codewars.com/kata/58649884a1659ed6cb000072

namespace codewars.com.Kata._8_kyu.Thinkful__Logic_Drills_Traffic_light
{
    using System.Collections.Generic;

    public class Kata
    {
        public static string UpdateLight(string current)
        {
            var res = new Dictionary<string, string>();
            res.Add("green", "yellow");
            res.Add("yellow", "red");
            res.Add("red", "green");
            return res[current];
        }
    }
}