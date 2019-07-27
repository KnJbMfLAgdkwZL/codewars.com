// Age Range Compatibility Equation
// https://www.codewars.com/kata/5803956ddb07c5c74200144e

namespace codewars.com.Kata._8_kyu.Age_Range_Compatibility_Equation
{
    public class Kata
    {
        public static string DatingRange(int age)
        {
            var min = 0;
            var max = 0;
            if (age <= 14)
            {
                min = (int) (age - 0.10 * age);
                max = (int) (age + 0.10 * age);
            }
            else
            {
                min = age / 2 + 7;
                max = (age - 7) * 2;
            }

            return $"{min}-{max}";
        }
    }
}