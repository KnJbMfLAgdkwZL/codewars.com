// Online RPG player to qualifying stage
// https://www.codewars.com/kata/55849d76acd73f6cc4000087

namespace codewars.com.Kata._8_kyu.Online_RPG_player_to_qualifying_stage
{
    using System;

    public class Kata
    {
        public static Object PlayerRankUp(int points)
        {
            if (points >= 100)
                return
                    "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.";
            return false;
        }
    }
}