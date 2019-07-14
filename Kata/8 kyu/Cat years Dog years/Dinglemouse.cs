// Cat years Dog years
// https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b

namespace codewars.com.Kata._8_kyu.Cat_years_Dog_years
{
    public class Dinglemouse
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            var human = humanYears;
            var cat = 0;
            var dog = 0;
            if (humanYears >= 1)
            {
                cat += 15;
                dog += 15;
                humanYears--;
            }

            if (humanYears >= 1)
            {
                cat += 9;
                dog += 9;
                humanYears--;
            }

            cat += humanYears * 4;
            dog += humanYears * 5;
            return new int[] {human, cat, dog};
        }
    }
}