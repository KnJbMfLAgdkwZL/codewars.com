// How old will I be in 2099
// https://www.codewars.com/kata/5761a717780f8950ce001473

namespace codewars.com.Kata._8_kyu.How_old_will_I_be_in_2099
{
    public static class AgeDiff
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            var r = yearTo - birth;
            if (r == 0)
                return "You were born this very year!";
            var y = (r == -1 || r == 1) ? "year" : "years";
            if (r < 0)
                return $"You will be born in {-r} {y}.";
            return $"You are {r} {y} old.";
        }
    }
}