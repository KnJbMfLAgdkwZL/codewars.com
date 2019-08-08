// Remove anchor from URL
// https://www.codewars.com/kata/51f2b4448cadf20ed0000386

namespace codewars.com.Kata._8_kyu.Remove_anchor_from_URL
{
    public static class Kata
    {
        public static string RemoveUrlAnchor(string url)
        {
            return url.Split("#")[0];
        }
    }
}