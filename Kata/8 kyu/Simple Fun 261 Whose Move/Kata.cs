// Simple Fun 261 Whose Move
// https://www.codewars.com/kata/59126992f9f87fd31600009b

namespace codewars.com.Kata._8_kyu.Simple_Fun_261_Whose_Move
{
    public class Kata
    {
        public static string WhoseMove(string lastPlayer, bool win)
        {
            if (win && lastPlayer == "black" || !win && lastPlayer != "black")
                return "black";
            return "white";
        }
    }
}