// Beginner Series 1 School Paperwork
// https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd

namespace codewars.com.Kata._8_kyu.Beginner_Series_1_School_Paperwork
{
    public static class Paper
    {
        public static int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0)
                return 0;
            return n * m;
        }
    }
}