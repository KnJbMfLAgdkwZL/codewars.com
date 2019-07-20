// Grasshopper  Grade book
// https://www.codewars.com/kata/55cbd4ba903825f7970000f5

namespace codewars.com.Kata._8_kyu.Grasshopper__Grade_book
{
    public class Kata
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            var score = ((s1 + s2 + s3) / 3);
            if (90 <= score && score <= 100)
                return 'A';
            if (80 <= score && score < 90)
                return 'B';
            if (70 <= score && score < 80)
                return 'C';
            if (60 <= score && score < 70)
                return 'D';
            if (0 <= score && score < 60)
                return 'F';
            return ' ';
        }
    }
}