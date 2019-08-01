// Grasshopper  Terminal Game 1
// https://www.codewars.com/kata/55e8aba23d399a59500000ce

namespace codewars.com.Kata._8_kyu.Grasshopper__Terminal_Game_1
{
    public class Hero
    {
        public string Name = "Hero";
        public string Position = "00";
        public float Health = 100;
        public float Damage = 5;
        public int Experience = 0;

        public Hero()
        {
        }

        public Hero(string name)
        {
            this.Name = name;
        }
    }
}