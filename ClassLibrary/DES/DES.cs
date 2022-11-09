using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DES
{
    public class DES
    {
        public static string encrypt(string message, string key)
        {
            StringBuilder sb = new StringBuilder();
            string binaryMessage;
            key = Operations.stringToBinary(key);
            while (message.Length != 0)
            {
                if (message.Length < 8)
                {
                    message = message.PadRight(8, ' ');
                }
                binaryMessage = Operations.stringToBinary(message.Substring(0, 8));
                sb.Append(encryptProcess(binaryMessage, key));
                if (message.Length > 8)
                {
                    message = message.Substring(8);
                }
                else
                {
                    message = "";
                }
            }
            return Operations.binaryToString(sb.ToString());
        }

        private static string encryptProcess(string message, string key)
        {
            string IP = Operations.matrixPermutation(Permutations.IP, message);
            string[] keys = Operations.getKeys(key);

            IP = Feistel.getFeistel(IP, keys);
            string encryptMessage = Operations.exchangeSides(IP);
            encryptMessage = Operations.matrixPermutation(Permutations.IP1, encryptMessage);

            return encryptMessage;
        }

        public static string decrypt(string message, string key)
        {
            StringBuilder sb = new StringBuilder();
            string binaryMessage;
            key = Operations.stringToBinary(key);
            while (message.Length > 0)
            {
                if (message.Length < 8)
                {
                    message = message.PadRight(8, ' ');
                }
                binaryMessage = Operations.stringToBinary(message.Substring(0, 8));
                sb.Append(decryptProcess(binaryMessage, key));
                if (message.Length > 8)
                {
                    message = message.Substring(8);
                }
                else
                {
                    message = "";
                }
            }
            return Operations.binaryToString(sb.ToString());
        }

        private static string decryptProcess(string encryptMessage, string key)
        {
            string IP = Operations.matrixPermutation(Permutations.IP, encryptMessage);
            string[] keys = Operations.getKeys(key);
            string[] auxKyes = new string[keys.Length];
            int j = 0;
            for (int i = keys.Length - 1; i >= 0; i--)
            {
                auxKyes[j] = keys[i];
                j++;
            }
            keys = auxKyes;
            IP = Feistel.getFeistel(IP, keys);
            string desencryptMessage = Operations.exchangeSides(IP);
            encryptMessage = Operations.matrixPermutation(Permutations.IP1, desencryptMessage);

            return encryptMessage;
        }
    }
}
