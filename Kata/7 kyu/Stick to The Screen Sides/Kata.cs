// Stick to The Screen Sides
// https://www.codewars.com/kata/5641d9d4aceb8e30dc0000aa

namespace codewars.com.Kata._8_kyu.Stick_to_The_Screen_Sides
{
    public class Kata
    {
        public static double[] newCoordinate(int w, int h, double stickMargin, double[] coordinate)
        {
            var x = coordinate[0];
            var y = coordinate[1];

            if (x > w || x < 0 || y > h || y < 0)
                return new double[] {0, 0};

            if (x >= w - stickMargin)
                x = w;

            else if (x <= stickMargin)
                x = 0;
            if (y >= h - stickMargin)
                y = h;
            else if (y <= stickMargin)
                y = 0;

            return new double[] {x, y};
        }
    }
}