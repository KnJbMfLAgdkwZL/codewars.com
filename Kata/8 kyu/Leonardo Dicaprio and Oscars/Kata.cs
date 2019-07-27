// Leonardo Dicaprio and Oscars
// https://www.codewars.com/kata/56d49587df52101de70011e4

namespace codewars.com.Kata._8_kyu.Leonardo_Dicaprio_and_Oscars
{
    public static class Kata
    {
        public static string Leo(int oscar)
        {
            if (oscar == 88)
                return "Leo finally won the oscar! Leo is happy";
            if (oscar == 86)
                return "Not even for Wolf of wallstreet?!";
            if (oscar < 88)
                return "When will you give Leo an Oscar?";
            return "Leo got one already!";
        }
    }
}