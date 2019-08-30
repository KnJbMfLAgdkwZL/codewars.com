// https://www.codewars.com/kata/577bd8d4ae2807c64b00045b
// Two fighters, one winner.

namespace codewars.com.Kata._7_kyu.Two_fighters_one_winner
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }

    public class Kata
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                if (fighter1.Name == firstAttacker)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    if (fighter2.Health > 0)
                        fighter1.Health -= fighter2.DamagePerAttack;
                }
                else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    if (fighter1.Health > 0)
                        fighter2.Health -= fighter1.DamagePerAttack;
                }
            }

            return (fighter1.Health > fighter2.Health) ? fighter1.Name : fighter2.Name;
        }
    }
}