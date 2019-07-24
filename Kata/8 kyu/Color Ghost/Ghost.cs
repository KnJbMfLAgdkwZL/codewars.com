// Color Ghost
// https://www.codewars.com/kata/53f1015fa9fe02cbda00111a

namespace codewars.com.Kata._8_kyu.Color_Ghost
{
    using System;

    public class Ghost
    {
        private readonly string _color;

        public Ghost()
        {
            var colors = new[] {"white", "yellow", "purple", "red"};
            var r = new Random().Next(0, colors.Length);
            this._color = colors[r];
        }

        public string GetColor()
        {
            return this._color;
        }
    }
}