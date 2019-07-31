// Classy Extentions
// https://www.codewars.com/kata/55a14aa4817efe41c20000bc

namespace codewars.com.Kata._8_kyu.Classy_Extentions
{
    public class Animal
    {
        protected string Name;

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual string Speak()
        {
            return "";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string Speak()
        {
            return $"{this.Name} meows.";
        }
    }
}