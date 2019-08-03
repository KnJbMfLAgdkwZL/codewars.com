// Broken Counter
// https://www.codewars.com/kata/526471539d52735c620000c6

namespace codewars.com.Kata._8_kyu.Broken_Counter
{
    public class Counter
    {
        private int _value;

        public int Value
        {
            get => _value;
            private set => _value = value;
        }

        public Counter() => Value = 0;
        public void Increase() => ++Value;
        public void Reset() => Value = 0;
    }
}