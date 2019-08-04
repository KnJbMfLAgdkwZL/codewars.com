// Get row from alphabetical sequence
// https://www.codewars.com/kata/5830195755f28edad4000081

namespace codewars.com.Kata._8_kyu.Get_row_from_alphabetical_sequence
{
    public class Kata
    {
        private static string[] sequence = new string[]
        {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "BBCDEFGHIJKLMNOPQRSTUVWXYZ",
            "CCCDEFGHIJKLMNOPQRSTUVWXYZ",
            "DDDDEFGHIJKLMNOPQRSTUVWXYZ",
            "EEEEEFGHIJKLMNOPQRSTUVWXYZ",
            "FFFFFFGHIJKLMNOPQRSTUVWXYZ",
            "GGGGGGGHIJKLMNOPQRSTUVWXYZ",
            "HHHHHHHHIJKLMNOPQRSTUVWXYZ",
            "IIIIIIIIIJKLMNOPQRSTUVWXYZ",
            "JJJJJJJJJJKLMNOPQRSTUVWXYZ",
            "KKKKKKKKKKKLMNOPQRSTUVWXYZ",
            "LLLLLLLLLLLLMNOPQRSTUVWXYZ",
            "MMMMMMMMMMMMMNOPQRSTUVWXYZ",
            "NNNNNNNNNNNNNNOPQRSTUVWXYZ",
            "OOOOOOOOOOOOOOOPQRSTUVWXYZ",
            "PPPPPPPPPPPPPPPPQRSTUVWXYZ",
            "QQQQQQQQQQQQQQQQQRSTUVWXYZ",
            "RRRRRRRRRRRRRRRRRRSTUVWXYZ",
            "SSSSSSSSSSSSSSSSSSSTUVWXYZ",
            "TTTTTTTTTTTTTTTTTTTTUVWXYZ",
            "UUUUUUUUUUUUUUUUUUUUUVWXYZ",
            "VVVVVVVVVVVVVVVVVVVVVVWXYZ",
            "WWWWWWWWWWWWWWWWWWWWWWWXYZ",
            "XXXXXXXXXXXXXXXXXXXXXXXXYZ",
            "YYYYYYYYYYYYYYYYYYYYYYYYYZ",
            "ZZZZZZZZZZZZZZZZZZZZZZZZZZ"
        };

        public static string GetRow(int numOfRow)
        {
            var i = numOfRow - 1;
            i %= sequence.Length;
            return sequence[i];
        }
    }
}