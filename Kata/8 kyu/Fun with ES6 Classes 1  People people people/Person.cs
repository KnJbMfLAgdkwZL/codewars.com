// Fun with ES6 Classes 1  People people people
// https://www.codewars.com/kata/56f7f8215d7c12c0e7000b19

namespace codewars.com.Kata._8_kyu.Fun_with_ES6_Classes_1__People_people_people
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }

        public string SayFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public static string GreetExtraTerrestrials(string raceName)
        {
            return $"Welcome to Planet Earth {raceName}";
        }
    }
}