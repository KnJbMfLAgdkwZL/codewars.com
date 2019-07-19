// Duck Duck Goose
// https://www.codewars.com/kata/582e0e592029ea10530009ce

namespace codewars.com.Kata._8_kyu.Duck_Duck_Goose
{
    public class Kata
    {
        public static string DuckDuckGoose(Player[] players, int goose)
        {
            return players[(goose - 1) % players.Length].Name;
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}