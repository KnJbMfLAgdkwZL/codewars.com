// Matching Plates
// https://www.codewars.com/kata/5883a3e547abc50eb60000bd

namespace codewars.com.Kata._7_kyu.Matching_Plates
{
    class Kata
    {
        public static bool matchingPlates(char[] meals, char[] stack)
        {
            var sI = stack.Length - 1;
            var mI = meals.Length - 1;
            if (mI > sI)
                return false;
            for (var i = mI; i > 0; i--)
                if (meals[mI] != stack[sI])
                    return false;
            return true;
            //return meals.SequenceEqual(stack.Take(meals.Length));
        }
    }
}