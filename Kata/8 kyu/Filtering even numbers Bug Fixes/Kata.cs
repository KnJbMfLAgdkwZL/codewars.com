// Filtering even numbers Bug Fixes
// https://www.codewars.com/kata/566dc566f6ea9a14b500007b

namespace codewars.com.Kata._8_kyu.Filtering_even_numbers_Bug_Fixes
{
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            return listOfNumbers.Where(v => v % 2 != 0).ToList();
        }
    }
}