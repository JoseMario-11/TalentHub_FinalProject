using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Algorithm
{
    public class HuffmanNode
    {
        public int Frequency { get; set; }
        public char? Symbol { get; set; }
        public bool IsLeaf { get; set; }
        public int Side { get; set; }
        public HuffmanNode Left { get; set; }
        public HuffmanNode Right { get; set; }

        public HuffmanNode()
        {
            Frequency = 0;
            Symbol = null;
            IsLeaf = false;
            Left = null;
            Right = null;
        }
    }

    public class Huffman
    {
        public HuffmanNode Tree { get; set; }

        public Huffman(string message)
        {
            Tree = GetHuffmanTree(message);
        }

        // Codificación del mensaje con el arbol de huffman
        public string CodeMessage(string message)
        {
            string code = "";
            string codeMessage = "";
            bool read = true;
            while (message.Length > 0)
            {
                InOrder(Tree, message[0], ref read, ref code);
                code = Reverse(code);
                code = code.Substring(2);
                codeMessage += code;
                if (message.Length != 1)
                {
                    read = true;
                    code = "";
                    message = message.Substring(1);
                }
                else
                {
                    message = "";
                }
            }
            return codeMessage;
        }

        HuffmanNode GetHuffmanTree(string message)
        {
            //Conteo de frecuencias
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            while (message.Length != 0)
            {
                var character = Convert.ToChar(message[0]);

                if (!frequency.ContainsKey(character))
                {
                    frequency.Add(character, 1);
                }
                else
                {
                    frequency[character] = frequency[character] + 1;
                }

                if (message.Length != 1)
                {
                    message = message.Substring(1);
                }
                else
                {
                    message = "";
                }
            }

            //Colocación de los elementos en una lista
            List<HuffmanNode> table = new List<HuffmanNode>();
            foreach (var item in frequency)
            {
                HuffmanNode aux = new HuffmanNode();
                aux.Symbol = item.Key;
                aux.Frequency = item.Value;
                table.Add(aux);
            }
            table.Sort((HuffmanNode x, HuffmanNode y) => x.Frequency - y.Frequency);

            //Armado Arbol de Huffman
            while (table.Count > 1)
            {
                HuffmanNode left = table[0];
                left.Side = 0;
                table.RemoveAt(0);
                HuffmanNode right = table[0];
                right.Side = 1;
                table.RemoveAt(0);
                if (left.Symbol != null)
                {
                    left.IsLeaf = true;
                }
                if (right.Symbol != null)
                {
                    right.IsLeaf = true;
                }
                HuffmanNode newNode = new HuffmanNode();
                newNode.Frequency = left.Frequency + right.Frequency;
                newNode.Left = left;
                newNode.Right = right;
                table.Add(newNode);
                table.Sort((HuffmanNode x, HuffmanNode y) => x.Frequency - y.Frequency);
            }
            table[0].Side = -1;

            return table[0];
        }

        // Lectura del arbol de Huffman
        void InOrder(HuffmanNode root, char? character, ref bool read, ref string code)
        {
            if (root.Left == null && root.Right == null)
            {
                if (root.Symbol == character)
                {
                    code += root.Side.ToString();
                    read = false;
                }
            }
            else if (root.Right == null)
            {
                if (read)
                {
                    InOrder(root.Left, character, ref read, ref code);
                    if (!read)
                    {
                        code += root.Side.ToString();
                    }
                }
            }
            else if (root.Left == null)
            {
                if (read)
                {
                    InOrder(root.Right, character, ref read, ref code);
                    if (!read)
                    {
                        code += root.Side.ToString();
                    }
                }
            }
            else
            {
                if (read)
                {
                    InOrder(root.Left, character, ref read, ref code);
                    if (!read)
                    {
                        code += root.Side.ToString();
                    }
                }
                if (read)
                {
                    InOrder(root.Right, character, ref read, ref code);
                    if (!read)
                    {
                        code += root.Side.ToString();
                    }
                }
            }
        }

        // Decodificación del código de Huffman con el árbol
        public string DecodingMessage(string code)
        {
            HuffmanNode aux = Tree;
            string decode = "";
            char bit;
            while (code.Length > 0)
            {
                while (!aux.IsLeaf)
                {
                    bit = code[0];
                    if (bit == '1')
                    {
                        aux = aux.Right;
                    }
                    else
                    {
                        aux = aux.Left;
                    }
                    if (code.Length > 1)
                    {
                        code = code.Substring(1);
                    }
                    else
                    {
                        code = "";
                    }
                }
                decode += aux.Symbol.ToString();
                aux = Tree;
            }
            return decode;
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
