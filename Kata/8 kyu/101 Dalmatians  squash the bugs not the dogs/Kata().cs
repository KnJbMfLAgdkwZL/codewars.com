// 101 Dalmatians  squash the bugs not the dogs
// https://www.codewars.com/kata/56f6919a6b88de18ff000b36

namespace codewars.com.Kata._8_kyu.d101_Dalmatians__squash_the_bugs_not_the_dogs
{
    public static class Kata
    {
        public static string HowManyDalmatians(int number)
        {
            if (number <= 10)
                return "Hardly any";
            if (number <= 50)
                return "More than a handful!";
            if (number == 101)
                return "101 DALMATIONS!!!";
            return "Woah that's a lot of dogs!";
        }
    }
}