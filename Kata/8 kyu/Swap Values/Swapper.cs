// Swap Values
// https://www.codewars.com/kata/5388f0e00b24c5635e000fc6

namespace codewars.com.Kata._8_kyu.Swap_Values
{
    public class Swapper
    {
        public object[] Arguments { get; private set; }

        public Swapper(object[] args)
        {
            Arguments = args;
        }

        public void SwapValues()
        {
            object temp = Arguments[1];
            Arguments[1] = Arguments[0];
            Arguments[0] = temp;
        }
    }
}