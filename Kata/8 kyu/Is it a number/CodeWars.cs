// Is it a number
// https://www.codewars.com/kata/57126304cdbf63c6770012bd

namespace codewars.com.Kata._8_kyu.Is_it_a_number
{
    public class CodeWars
    {
        public static bool IsDigit(string s)
        {
            return float.TryParse(s, out var num);
        }
    }
}