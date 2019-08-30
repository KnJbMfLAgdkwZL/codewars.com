// Compare Strings by Sum of Chars
// https://www.codewars.com/kata/576bb3c4b1abc497ec000065

namespace codewars.com.Kata._7_kyu.Compare_Strings_by_Sum_of_Chars
{
    public static class Kata
    {
        public static bool Compare(string s1, string s2)
        {
            var sum1 = 0;
            if (!string.IsNullOrEmpty(s1))
                foreach (var v in s1.ToUpper())
                {
                    if (!char.IsLetter(v))
                    {
                        sum1 = 0;
                        break;
                    }

                    sum1 += v;
                }

            var sum2 = 0;
            if (!string.IsNullOrEmpty(s2))
                foreach (var v in s2.ToUpper())
                {
                    if (!char.IsLetter(v))
                    {
                        sum2 = 0;
                        break;
                    }

                    sum2 += v;
                }

            return sum1 == sum2;
        }
    }
}