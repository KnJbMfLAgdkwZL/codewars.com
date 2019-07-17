// Unfinished Loop  Bug Fixing 1
// https://www.codewars.com/kata/55c28f7304e3eaebef0000da

namespace codewars.com.Kata._8_kyu.Unfinished_Loop__Bug_Fixing_1
{
    using System.Collections.Generic;

    public class Kata
    {
        public static List<int> CreateList(int number)
        {
            var list = new List<int>();
            for (var counter = 1; counter <= number; counter++)
                list.Add(counter);
            return list;
        }
    }
}