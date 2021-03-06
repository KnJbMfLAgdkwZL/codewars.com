// Subtract the Sum
// https://www.codewars.com/kata/56c5847f27be2c3db20009c3

namespace codewars.com.Kata._8_kyu.Subtract_the_Sum
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static string SubtractSum(int number)
        {
            string[] fruts = new[]
            {
                "", "kiwi", "pear", "kiwi", "banana", "melon", "banana", "melon", "pineapple", "apple", "pineapple",
                "cucumber", "pineapple", "cucumber", "orange", "grape", "orange", "grape", "apple", "grape", "cherry",
                "pear", "cherry", "pear", "kiwi", "banana", "kiwi", "apple", "melon", "banana", "melon", "pineapple",
                "melon", "pineapple", "cucumber", "orange", "apple", "orange", "grape", "orange", "grape", "cherry",
                "pear", "cherry", "pear", "apple", "pear", "kiwi", "banana", "kiwi", "banana", "melon", "pineapple",
                "melon", "apple", "cucumber", "pineapple", "cucumber", "orange", "cucumber", "orange", "grape",
                "cherry", "apple", "cherry", "pear", "cherry", "pear", "kiwi", "pear", "kiwi", "banana", "apple",
                "banana", "melon", "pineapple", "melon", "pineapple", "cucumber", "pineapple", "cucumber", "apple",
                "grape", "orange", "grape", "cherry", "grape", "cherry", "pear", "cherry", "apple", "kiwi", "banana",
                "kiwi", "banana", "melon", "banana", "melon", "pineapple", "apple", "pineapple"
            };
            var s = number.ToString().Select(v => int.Parse(v.ToString())).Sum();
            var n = number - s;
            Console.WriteLine(n);
            return n < fruts.Length ? fruts[n] : SubtractSum(n);
        }
    }
}