// Remove String Spaces
// https://www.codewars.com/kata/57eae20f5500ad98e50002c5

namespace Remove_String_Spaces
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}