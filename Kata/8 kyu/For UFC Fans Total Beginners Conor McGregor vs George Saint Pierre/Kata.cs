// For UFC Fans Total Beginners Conor McGregor vs George Saint Pierre
// https://www.codewars.com/kata/582dafb611d576b745000b74

namespace codewars.com.Kata._8_kyu.For_UFC_Fans_Total_Beginners_Conor_McGregor_vs_George_Saint_Pierre
{
    public static class Kata
    {
        public static string Quote(string fighter)
        {
            if (fighter.ToLower() == "conor mcgregor")
                return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
            return "I am not impressed by your performance.";
        }
    }
}