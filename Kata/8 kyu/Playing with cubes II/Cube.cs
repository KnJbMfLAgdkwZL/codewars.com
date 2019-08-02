// Playing with cubes II
// https://www.codewars.com/kata/55c0ac142326fdf18d0000af

namespace codewars.com.Kata._8_kyu.Playing_with_cubes_II
{
    using System;

    public class Cube
    {
        private int Side;

        public Cube()
        {
            this.SetSide(0);
        }

        public Cube(int s)
        {
            this.SetSide(s);
        }

        public int GetSide()
        {
            return this.Side;
        }

        public void SetSide(int s)
        {
            this.Side = Math.Abs(s);
        }
    }
}