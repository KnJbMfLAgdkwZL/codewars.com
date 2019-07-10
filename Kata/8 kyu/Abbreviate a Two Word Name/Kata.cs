// Abbreviate a Two Word Name
// https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3

namespace codewars.com.Kata._8_kyu.Abbreviate_a_Two_Word_Name
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            var r = name.ToUpper().Split(' ');
            return $"{r[0][0]}.{r[1][0]}";
        }
    }
}