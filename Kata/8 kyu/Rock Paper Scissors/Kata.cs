// Rock Paper Scissors!
// https://www.codewars.com/kata/5672a98bdbdd995fad00000f

namespace codewars.com.Kata._8_kyu.Rock_Paper_Scissors
{
    public class Kata
    {
        public string Rps(string p1, string p2)
        {
            if (p1 == p2)
            {
                return "Draw!";
            }

            if (p1 == "rock" && p2 == "scissors" || p1 == "scissors" && p2 == "paper" || p1 == "paper" && p2 == "rock")
            {
                return "Player 1 won!";
            }

            return "Player 2 won!";
        }
    }
}