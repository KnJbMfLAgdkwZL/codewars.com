// Simple beads count
// https://www.codewars.com/kata/58712dfa5c538b6fc7000569

namespace codewars.com.Kata._8_kyu.Simple_beads_count
{
    public static class Kata
    {
        public static int CountRedBeads(int n)
        {
            if (n == 0)
                return 0;
            return (n - 1) * 2;
        }
    }
}