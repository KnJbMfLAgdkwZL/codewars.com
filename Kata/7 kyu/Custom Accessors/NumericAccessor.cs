// Custom Accessors
// https://www.codewars.com/kata/58cfa163c496ce8856000064

namespace codewars.com.Kata._7_kyu.Custom_Accessors
{
    namespace CustomAccessors
    {
        using System;

        public class NumericAccessor
        {
            private int _number;

            public int Number
            {
                get { return _number / 2; }
                set
                {
                    if (value % 2 == 0)
                        _number = value;
                    else
                        throw new ArgumentException();
                }
            }
        }
    }
}