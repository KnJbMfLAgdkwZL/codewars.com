// The if function
// https://www.codewars.com/kata/54147087d5c2ebe4f1000805

namespace codewars.com.Kata._8_kyu.The_if_function
{
    using System;

    public class Kata
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            if (condition)
                func1();
            else
                func2();
        }
    }
}