// Classy Classes
// https://www.codewars.com/kata/55a144eff5124e546400005a

namespace codewars.com.Kata._8_kyu.Classy_Classes
{
    public class Person
    {
        private string name { get; set; }
        private int age { get; set; }
        public string Info { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.Info = $"{this.name}s age is {this.age}";
        }
    }
}