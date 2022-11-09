using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TalentHubLab1.RecommendationLetters;

namespace TalentHubLab1.Conversations
{
    public class Conversation
    {
        public string OriginalContent;
        public string EncryptedConversation;
        public string Key;
        public String[,] EncryptMatrix;
        public String[,] DecryptMatrix;
        public int[] LetterValues;
        public int[] columnOrder;

        public Dictionary<string, int> LetterToNumber = new Dictionary<string, int>
        {
            ["a"] = 1,
            ["b"] = 2,
            ["c"] = 3,
            ["d"] = 4,
            ["e"] = 5,
            ["f"] = 6,
            ["g"] = 7,
            ["h"] = 8,
            ["i"] = 9,
            ["j"] = 10,
            ["k"] = 11,
            ["l"] = 12,
            ["m"] = 13,
            ["n"] = 14,
            ["o"] = 15,
            ["p"] = 16,
            ["q"] = 17,
            ["r"] = 18,
            ["s"] = 19,
            ["t"] = 20,
            ["u"] = 21,
            ["v"] = 22,
            ["w"] = 23,
            ["x"] = 24,
            ["y"] = 25,
            ["z"] = 26,
        };

        public Dictionary<int, string> NumberToLetter = new Dictionary<int, String>
        {
            [1] = "a",
            [2] = "b",
            [3] = "c",
            [4] = "d",
            [5] = "e",
            [6] = "f",
            [7] = "g",
            [8] = "h",
            [9] = "i",
            [10] = "j",
            [11] = "k",
            [12] = "l",
            [13] = "m",
            [14] = "n",
            [15] = "o",
            [16] = "p",
            [17] = "q",
            [18] = "r",
            [19] = "s",
            [20] = "t",
            [21] = "u",
            [22] = "v",
            [23] = "w",
            [24] = "x",
            [25] = "y",
            [26] = "z",
        };
        public Conversation(string OriginalText, string Key)
        {
            OriginalContent = OriginalText.Trim().ToLower();
            this.Key = Key;
            LetterValues = new int[Key.Length];
            EncryptedConversation = "";

            for (int i = 0; i < LetterValues.Length; i++)
            {
                LetterValues[i] = LetterToNumber[Key[i].ToString()];
            }

            columnOrder = GetColumnOrder();
        }

        public string Encrypt()
        {
            //matrix generation
            EncryptMatrix = new string[Key.Length, (OriginalContent.Length / Key.Length)];
            DecryptMatrix = new string[Key.Length, (OriginalContent.Length / Key.Length)];

            int positionOriginalContent = 0;
            for (int i = 0; i < EncryptMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < EncryptMatrix.GetLength(0); j++)
                {
                    if (positionOriginalContent < OriginalContent.Length)
                    {
                        EncryptMatrix[j, i] = OriginalContent[positionOriginalContent].ToString();
                        positionOriginalContent++;
                    }
                }
            }

            

            for (int column = 0; column< columnOrder.Length; column++)
            {
                for (int row = 0; row < EncryptMatrix.GetLength(1); row++)
                {
                    EncryptedConversation += EncryptMatrix[column, row].ToString();
                }
            }

            return EncryptedConversation;
        }

        public string Decrypt()
        {
            //var columnOrder = GetColumnOrder();
            int groupLength = OriginalContent.Length / Key.Length;
            string auxEncrypt = EncryptedConversation;
            string output = "";
            int textPosition = 0;
            for (int column = 0; column < columnOrder.Length; column++)
            {
                for (int row = 0; row < DecryptMatrix.GetLength(1); row++)
                {
                    DecryptMatrix[column, row] = auxEncrypt.Substring(textPosition, 1);
                    textPosition++;
                }
            }


            for (int i = 0; i < DecryptMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < DecryptMatrix.GetLength(0); j++)
                {
                    output += DecryptMatrix[j, i];
                }
            }

            return output;
        }

        public int[] GetColumnOrder()
        {
            int[] aux = LetterValues;
            int[] columnOrder = LetterValues;
            Array.Sort(aux);
            
            for (int i = 0; i < aux.Length; i++)
            {
                columnOrder[i] = Key.IndexOf(NumberToLetter[aux[i]]);
            }

            return columnOrder;
        }
    }
}
