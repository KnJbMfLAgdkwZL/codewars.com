// Add new item collections are passed by reference
// https://www.codewars.com/kata/566dc05f855b36a031000048

namespace codewars.com.Kata._8_kyu.Add_new_item_collections_are_passed_by_reference
{
    using System.Linq;
    using System.Collections.Generic;

    public class AddMore
    {
        public static List<int> AddExtra(List<int> listOfNumbers)
        {
            var r = listOfNumbers.ToList();
            r.Add(0);
            return r;
        }
    }
}