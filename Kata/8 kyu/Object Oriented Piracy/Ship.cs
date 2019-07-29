// Object Oriented Piracy
// https://www.codewars.com/kata/54fe05c4762e2e3047000add

namespace codewars.com.Kata._8_kyu.Object_Oriented_Piracy
{
    public class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt()
        {
            var r = Draft - Crew * 1.5;
            return r > 20;
        }
    }
}