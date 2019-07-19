// Grasshopper  Terminal game combat function
// https://www.codewars.com/kata/586c1cf4b98de0399300001d

namespace codewars.com.Kata._8_kyu.Grasshopper__Terminal_game_combat_function
{
    public static class Game
    {
        public static float Combat(float health, float damage)
        {
            var res = health - damage;
            if (res < 0)
                return 0;
            return res;
        }
    }
}