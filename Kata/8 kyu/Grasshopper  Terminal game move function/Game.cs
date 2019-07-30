// Grasshopper  Terminal game move function
// https://www.codewars.com/kata/563a631f7cbbc236cf0000c2

namespace codewars.com.Kata._8_kyu.Grasshopper__Terminal_game_move_function
{
    public class Game
    {
        public static int Move(int position, int roll)
        {
            return roll * 2 + position;
        }
    }
}