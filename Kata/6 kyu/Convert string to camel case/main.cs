// Convert string to camel case
// https://www.codewars.com/kata/517abf86da9663f1d2000003

namespace Convert_string_to_camel_case
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            var arr = str.Split("-");
            str = string.Join(" ", arr);
            arr = str.Split("_");
            str = string.Join(" ", arr);
            arr = str.Split(" ");
            for (var i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                    continue;
                arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            }

            return string.Join("", arr);
        }
    }
}