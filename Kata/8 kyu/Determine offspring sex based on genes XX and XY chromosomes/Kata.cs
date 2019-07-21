// Determine offspring sex based on genes XX and XY chromosomes
// https://www.codewars.com/kata/56530b444e831334c0000020

namespace codewars.com.Kata._8_kyu.Determine_offspring_sex_based_on_genes_XX_and_XY_chromosomes
{
    public class Kata
    {
        public static string ChromosomeCheck(string sperm)
        {
            var res = sperm == "XY" ? "son" : "daughter";
            return $"Congratulations! You're going to have a {res}.";
        }
    }
}