// L1 Bartender drinks
// https://www.codewars.com/kata/568dc014440f03b13900001d

namespace codewars.com.Kata._8_kyu.L1_Bartender_drinks
{
    using System.Collections.Generic;

    public class Kata
    {
        public static string GetDrinkByProfession(string p)
        {
            var drink = new Dictionary<string, string>();
            drink["jabroni"] = "Patron Tequila";
            drink["school counselor"] = "Anything with Alcohol";
            drink["programmer"] = "Hipster Craft Beer";
            drink["bike gang member"] = "Moonshine";
            drink["politician"] = "Your tax dollars";
            drink["rapper"] = "Cristal";
            if (drink.ContainsKey(p.ToLower()))
                return drink[p.ToLower()];
            return "Beer";
        }
    }
}