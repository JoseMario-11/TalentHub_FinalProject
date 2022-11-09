using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DES
{
    public class Feistel
    {
        static string feistelFunction(string value, string key)
        {
            string expanded = Operations.matrixPermutation(Permutations.E, value);
            string xorResult = Operations.xorResult(expanded, key);
            string sbox = Operations.sboxProcess(xorResult);
            return Operations.matrixPermutation(Permutations.P,sbox);
        }

        public static string getFeistelRound(string left, string right, string key)
        {
            string auxRight = right;
            string feistel = feistelFunction(right, key);
            right = Operations.xorResult(feistel, left);
            left = auxRight;
            return left + right;
        }

        public static string getFeistel(string value, string[] keys)
        {
            foreach (string key in keys)
            {
                value = getFeistelRound(value.Substring(0, 32), value.Substring(32, 32), key);
            }
            return value;
        }
    }
}
