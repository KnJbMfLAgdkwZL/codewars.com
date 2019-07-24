// Basic subclasses  Adam and Eve
// https://www.codewars.com/kata/547274e24481cfc469000416

namespace codewars.com.Kata._8_kyu.Basic_subclasses__Adam_and_Eve
{
    public class Human
    {
    }

    public class Man : Human
    {
    }

    public class Woman : Man
    {
    }

    public class God
    {
        public static Human[] Create()
        {
            return new Human[] {new Man(), new Woman()};
        }
    }
}    