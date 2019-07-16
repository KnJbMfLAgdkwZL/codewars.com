// Students Final Grade
// https://www.codewars.com/kata/5ad0d8356165e63c140014d4

namespace codewars.com.Kata._8_kyu.Students_Final_Grade
{
    public class Kata
    {
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10)
                return 100;
            if (exam > 75 && projects >= 5)
                return 90;
            if (exam > 50 && projects >= 2)
                return 75;
            return 0;
        }
    }
}