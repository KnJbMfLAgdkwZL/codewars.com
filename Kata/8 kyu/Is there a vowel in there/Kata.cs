// Is there a vowel in there
// https://www.codewars.com/kata/57cff961eca260b71900008f

namespace codewars.com.Kata._8_kyu.Is_there_a_vowel_in_there
{
    public class Kata
    {
        public static object[] IsVow(object[] a)
        {
            const string vowels = "aeiou";
            for (var i = 0; i < a.Length; i++)
            {
                var v = (char) (int) a[i];
                if (vowels.Contains(v))
                    a[i] = v.ToString();
            }

            return a;
        }
    }
}