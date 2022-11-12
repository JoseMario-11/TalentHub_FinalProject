using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Algorithm.DES
{
    public class Operation
    {
        public static string stringToBinary(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char character in text.ToCharArray())
            {
                sb.Append(Convert.ToString(character, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string binaryToString(string bits)
        {
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < bits.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(bits.Substring(i, 8), 2));
            }
            Encoding iso_8859_1 = Encoding.GetEncoding("ISO-8859-1");
            return iso_8859_1.GetString(byteList.ToArray());
        }

        public static string matrixPermutation(int[] matrix, string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var pos in matrix)
            {
                sb.Append(value[pos - 1]);
            }
            return sb.ToString();
        }

        public static string ShiftLeft(string value, int times)
        {
            if (times > 0)
            {
                while (times > 0)
                {
                    string first = value[0].ToString();
                    value = value.Substring(1) + first;
                    times--;
                }
                return value;
            }
            return null;
        }

        public static string[] getKeys(string key)
        {
            string[] keys = new string[16];
            string keyWithoutParity = matrixPermutation(Permutations.PC1, key);
            string left = keyWithoutParity.Substring(0, 28);
            string rigth = keyWithoutParity.Substring(28, 28);
            int times = 0;

            for (int round = 1; round <= 16; round++)
            {
                if (round == 1 || round == 2 || round == 9 || round == 16)
                {
                    times = 1;
                }
                else
                {
                    times = 2;
                }
                left = ShiftLeft(left, times);
                rigth = ShiftLeft(rigth, times);

                keys[round - 1] = matrixPermutation(Permutations.PC2, left + rigth);
            }
            return keys;
        }

        public static string xorResult(string a, string b)
        {
            char[] aArray = a.ToCharArray();
            char[] bArray = b.ToCharArray();
            StringBuilder result = new StringBuilder();
            if (aArray.Length == bArray.Length)
            {
                for (int i = 0; i < aArray.Length; i++)
                {
                    result.Append(XOR(aArray[i], bArray[i]));
                }
            }
            return result.ToString();
        }

        static char XOR(char a, char b)
        {
            if (a == '1')
            {
                if (b == '1') { return '0'; }
                else { return '1'; }
            }
            else
            {
                if (b == '1') { return '1'; }
                else { return '0'; }
            }
        }

        public static string sboxProcess(string value)
        {
            int i = 0;
            int position = 1;
            int row;
            int col;
            StringBuilder sb = new StringBuilder();
            while (i < value.Length)
            {
                string binaryrow = value[i].ToString() + value[i + 5].ToString();
                string binarycol = value.Substring(i + 1, 4);
                row = Convert.ToInt32(binaryrow, 2) - 1;
                col = Convert.ToInt32(binarycol, 2) - 1;
                if (row < 0) row = 0;
                if (col < 0) col = 0;
                switch (position)
                {
                    case 1: sb.Append(Convert.ToString(SBoxes.S1[row, col], 2).PadLeft(4, '0')); break;
                    case 2: sb.Append(Convert.ToString(SBoxes.S2[row, col], 2).PadLeft(4, '0')); break;
                    case 3: sb.Append(Convert.ToString(SBoxes.S3[row, col], 2).PadLeft(4, '0')); break;
                    case 4: sb.Append(Convert.ToString(SBoxes.S4[row, col], 2).PadLeft(4, '0')); break;
                    case 5: sb.Append(Convert.ToString(SBoxes.S5[row, col], 2).PadLeft(4, '0')); break;
                    case 6: sb.Append(Convert.ToString(SBoxes.S6[row, col], 2).PadLeft(4, '0')); break;
                    case 7: sb.Append(Convert.ToString(SBoxes.S7[row, col], 2).PadLeft(4, '0')); break;
                    case 8: sb.Append(Convert.ToString(SBoxes.S8[row, col], 2).PadLeft(4, '0')); break;
                    default:
                        break;
                }
                i = i + 6;
                position++;
            }
            return sb.ToString();
        }

        public static string exchangeSides(string message)
        {
            return message.Substring(32, 32) + message.Substring(0, 32);
        }
    }
}
