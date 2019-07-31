// Crash Override
// https://www.codewars.com/kata/578c1e2edaa01a9a02000b7f

namespace codewars.com.Kata._8_kyu.Crash_Override
{
    public partial class Kata
    {
        public static string AliasGen(string fName, string lName)
        {
            var f = fName[0].ToString();
            var l = lName[0].ToString();
            const string alp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!alp.Contains(f) || !alp.Contains(l))
                return "Your name must start with a letter from A - Z.";
            //string fn = FirstName[f];
            //string sn = Surname[l];
            //return $"{fn} {sn}";
            return "";
        }
    }
}