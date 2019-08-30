// Substituting Variables Into Strings Padded Numbers
// https://www.codewars.com/kata/51c89385ee245d7ddf000001

namespace codewars.com.Kata._7_kyu.Substituting_Variables_Into_Strings_Padded_Numbers
{
    public class PaddedNumbers
    {
        public static string Solution(int value)
        {
            return $"Value is {value.ToString().PadLeft(5, '0')}";
        }
    }
}