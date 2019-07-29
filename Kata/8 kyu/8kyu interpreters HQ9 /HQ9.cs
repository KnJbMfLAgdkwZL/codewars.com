// 8kyu interpreters HQ9 
// https://www.codewars.com/kata/591588d49f4056e13f000001

namespace codewars.com.Kata._8_kyu._8kyu_interpreters_HQ9_
{
    public class HQ9
    {
        public static string bottles(int i)
        {
            var tmp = $"{i} bottles";
            if (i == 1)
                tmp = $"{i} bottle";
            if (i == 0)
                tmp = "no more bottles";
            return tmp;
        }

        public static string Interpret(string code)
        {
            if (code == "H")
                return "Hello World!";
            if (code == "Q")
                return "Q";
            if (code == "9")
            {
                var str = "";
                for (var i = 99; i > 0; i--)
                {
                    var tmp = bottles(i);
                    str += $"{tmp} of beer on the wall, {tmp} of beer.\n";
                    str += $"Take one down and pass it around, {bottles(i - 1)} of beer on the wall.\n";
                }

                str += $"No more bottles of beer on the wall, no more bottles of beer.\n";
                str += $"Go to the store and buy some more, 99 bottles of beer on the wall.";
                return str;
            }

            return null;
        }
    }
}