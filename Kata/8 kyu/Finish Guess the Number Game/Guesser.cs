// Finish Guess the Number Game
// https://www.codewars.com/kata/568018a64f35f0c613000054

namespace codewars.com.Kata._8_kyu.Finish_Guess_the_Number_Game
{
    using System;

    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (this.lives < 1)
                throw new Exception();
            if (this.number == n)
                return true;
            this.lives--;
            return false;
        }
    }
}