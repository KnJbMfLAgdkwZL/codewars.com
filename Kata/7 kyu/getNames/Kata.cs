// getNames
// https://www.codewars.com/kata/514a677421607afc99000002

namespace codewars.com.Kata._8_kyu.getNames
{
    using System.Linq;

    public class Person
    {
        public int Age;
        public string Name;

        public Person(string name = "John", int age = 21)
        {
            Age = age;
            Name = name;
        }
    }

    public class Kata
    {
        public static string[] GetNames(Person[] data)
        {
            return data.Select(v => v.Name).ToArray();
        }
    }
}