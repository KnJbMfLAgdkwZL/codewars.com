// Grasshopper  Ifelse syntax debug
// https://www.codewars.com/kata/57089707fe2d01529f00024a

namespace codewars.com.Kata._8_kyu.Grasshopper__Ifelse_syntax_debug
{
    public class Player
    {
        private int health = 100;

        public int Health
        {
            get { return this.health; }
            set { health = value; }
        }

        public Player()
        {
        }

        public bool CheckAlive()
        {
            return this.Health > 0;
        }
    }
}