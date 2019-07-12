// altERnaTIng cAsE ALTerNAtiNG CaSe
// https://www.codewars.com/kata/56efc695740d30f963000557

namespace codewars.com.Kata._8_kyu.altERnaTIng_cAsE_ALTerNAtiNG_CaSe
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            var r = "";
            foreach (var v in s)
            {
                if (char.IsUpper(v))
                    r += char.ToLower(v);
                else if (char.IsLower(v))
                    r += char.ToUpper(v);
                else
                    r += v;
            }

            return r;
        }
    }
}