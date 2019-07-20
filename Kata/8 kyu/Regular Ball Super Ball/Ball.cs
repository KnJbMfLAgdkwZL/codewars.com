// Regular Ball Super Ball
// https://www.codewars.com/kata/53f0f358b9cb376eca001079

namespace codewars.com.Kata._8_kyu.Regular_Ball_Super_Ball
{
    public class Ball
    {
        public string ballType { get; set; }

        public Ball()
        {
            this.ballType = "regular";
        }

        public Ball(string ballType)
        {
            this.ballType = ballType;
        }
    }
}