// Calculate BMI
// https://www.codewars.com/kata/57a429e253ba3381850000fb

namespace codewars.com.Kata._8_kyu.Calculate_BMI
{
    public class Kata
    {
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);
            if (bmi <= 18.5) return "Underweight";
            if (bmi <= 25.0) return "Normal";
            if (bmi <= 30) return "Overweight";
            if (bmi > 30) return "Obese";
            return "";
        }
    }
}