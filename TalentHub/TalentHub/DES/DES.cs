using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.DES
{
    public class DES
    {
        public static string encrypt(string message, string key)
        {
            StringBuilder sb = new StringBuilder();
            string binaryMessage;
            key = Operation.stringToBinary(key);
            while (message.Length != 0)
            {
                if (message.Length < 8)
                {
                    message = message.PadRight(8, ' ');
                }
                binaryMessage = Operation.stringToBinary(message.Substring(0, 8));
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
            return Operation.binaryToString(sb.ToString());
        }

        private static string encryptProcess(string message, string key)
        {
            string IP = Operation.matrixPermutation(Permutations.IP, message);
            string[] keys = Operation.getKeys(key);

            IP = Feistel.getFeistel(IP, keys);
            string encryptMessage = Operation.exchangeSides(IP);
            encryptMessage = Operation.matrixPermutation(Permutations.IP1, encryptMessage);

            return encryptMessage;
        }

        public static string decrypt(string message, string key)
        {
            StringBuilder sb = new StringBuilder();
            string binaryMessage;
            key = Operation.stringToBinary(key);
            while (message.Length > 0)
            {
                if (message.Length < 8)
                {
                    message = message.PadRight(8, ' ');
                }
                binaryMessage = Operation.stringToBinary(message.Substring(0, 8));
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
            return Operation.binaryToString(sb.ToString());
        }

        private static string decryptProcess(string encryptMessage, string key)
        {
            string IP = Operation.matrixPermutation(Permutations.IP, encryptMessage);
            string[] keys = Operation.getKeys(key);
            string[] auxKyes = new string[keys.Length];
            int j = 0;
            for (int i = keys.Length - 1; i >= 0; i--)
            {
                auxKyes[j] = keys[i];
                j++;
            }
            keys = auxKyes;
            IP = Feistel.getFeistel(IP, keys);
            string desencryptMessage = Operation.exchangeSides(IP);
            encryptMessage = Operation.matrixPermutation(Permutations.IP1, desencryptMessage);

            return encryptMessage;
        }
    }
}
