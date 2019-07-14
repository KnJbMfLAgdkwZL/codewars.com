// Will there be enough space
// https://www.codewars.com/kata/5875b200d520904a04000003

namespace codewars.com.Kata._8_kyu.Will_there_be_enough_space
{
    public static class Kata
    {
        public static int Enough(int cap, int on, int wait)
        {
            var s = on + wait;
            if (s <= cap)
                return 0;
            return s - cap;
        }
    }
}