// Switch it Up
// https://www.codewars.com/kata/5808dcb8f0ed42ae34000031

namespace codewars.com.Kata._8_kyu.Switch_it_Up
{
    public class Kata
    {
        public static string SwitchItUp(int number)
        {
            var num = new[]
            {
                "Zero",
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine"
            };
            return num[number];
        }
    }
}