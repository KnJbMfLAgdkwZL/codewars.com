// Price of Mangoes
// https://www.codewars.com/kata/57a77726bb9944d000000b06

namespace codewars.com.Kata._8_kyu.Price_of_Mangoes
{
    public class Kata
    {
        public static int Mango(int quantity, int price)
        {
            return (quantity / 3 * 2 + quantity % 3) * price;
        }
    }
}