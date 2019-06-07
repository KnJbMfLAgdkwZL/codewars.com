// Build Tower
// https://www.codewars.com/kata/576757b1df89ecf5bd00073b

namespace Build_Tower
{
    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            var res = new string[nFloors];
            var n = 1;
            for (var i = 0; i < nFloors; i++)
            {
                var space = new string(' ', nFloors - n / 2 - 1);
                res[i] = space + new string('*', n) + space;
                n += 2;
            }

            return res;
        }
    }
}