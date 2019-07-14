// Welcome
// https://www.codewars.com/kata/577ff15ad648a14b780000e7

namespace codewars.com.Kata._8_kyu.Welcome
{
    using System.Collections.Generic;

    public static class Kata
    {
        public static string Greet(string language)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("english", "Welcome");
            dic.Add("czech", "Vitejte");
            dic.Add("danish", "Velkomst");
            dic.Add("dutch", "Welkom");
            dic.Add("estonian", "Tere tulemast");
            dic.Add("finnish", "Tervetuloa");
            dic.Add("flemish", "Welgekomen");
            dic.Add("french", "Bienvenue");
            dic.Add("german", "Willkommen");
            dic.Add("irish", "Failte");
            dic.Add("italian", "Benvenuto");
            dic.Add("latvian", "Gaidits");
            dic.Add("lithuanian", "Laukiamas");
            dic.Add("polish", "Witamy");
            dic.Add("spanish", "Bienvenido");
            dic.Add("swedish", "Valkommen");
            dic.Add("welsh", "Croeso");
            return dic.ContainsKey(language) ? dic[language] : dic["english"];
        }
    }
}