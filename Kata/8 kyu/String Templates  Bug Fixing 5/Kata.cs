// String Templates  Bug Fixing 5
// https://www.codewars.com/kata/55c90cad4b0fe31a7200001f

namespace codewars.com.Kata._8_kyu.String_Templates__Bug_Fixing_5
{
    public static class Kata
    {
        public static string buildString(string[] args)
        {
            return string.Format("I like {0}!", string.Join(", ", args));
        }
    }
}