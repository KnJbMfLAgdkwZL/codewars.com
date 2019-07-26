// Drink about
// https://www.codewars.com/kata/56170e844da7c6f647000063

namespace codewars.com.Kata._8_kyu.Drink_about
{
    public class Kata
    {
        public static string PeopleWithAgeDrink(int old)
        {
            var str = "";
            if (old >= 21)
                str = "drink whisky";
            if (old < 21)
                str = "drink beer";
            if (old < 18)
                str = "drink coke";
            if (old < 14)
                str = "drink toddy";
            return str;
        }
    }
}