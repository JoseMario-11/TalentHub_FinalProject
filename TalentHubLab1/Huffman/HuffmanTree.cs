using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHubLab1.Huffman
{
    public class HuffmanTree
    {
        public Dictionary<char, string> HuffmanCodesDictionary; //for encoding process
        public Dictionary<char, int> FrequencyDictionary;
        public HuffmanNode Root;
        public List<HuffmanNode> NodeList;
        public string DPIcodificated;
        
        public Func<HuffmanNode, HuffmanNode, int> CompareNodes = (node1, node2) =>
        {
            return node1.Frequency > node2.Frequency ? 1 : -1;
        };

        public HuffmanTree()
        {
            HuffmanCodesDictionary = new Dictionary<char, string>();
            FrequencyDictionary = new Dictionary<char, int>();
            NodeList = new List<HuffmanNode>();
            DPIcodificated = "";
        }
        
        public void SortNodeList()
        {
            for (int i = 0; i < NodeList.Count; i++)
            {
                for (int j = 0; j< NodeList.Count-1; j++)
                {
                    if (NodeList[j].Frequency > NodeList[j+1].Frequency)
                    {
                        HuffmanNode temp = NodeList[j + 1];
                        NodeList[j + 1] = NodeList[j];
                        NodeList[j] = temp;
                    }
                }
            }
        }
 
        public void CreateFrequencyDictionary(string text)
        {
            foreach(char c in text)
            {
                if (FrequencyDictionary.Keys.Contains(c))
                {
                    FrequencyDictionary[c]++;
                }
                else
                {
                    FrequencyDictionary.Add(c, 1);
                }
            }
        }

        public void CreateTree(string text)
        {
            CreateFrequencyDictionary(text);
            foreach (char key in FrequencyDictionary.Keys)
            {
                NodeList.Add(new HuffmanNode(key, FrequencyDictionary[key]));
            }

            CreateTree();
            Encode(text);
        }

        private void CreateTree()
        {
            if (NodeList.Count == 1)
            {
                return;
            }
            else if (NodeList.Count > 1)
            {
                SortNodeList();
                int sum = NodeList.ElementAt(0).Frequency + NodeList.ElementAt(1).Frequency;
                Root = new HuffmanNode(sum);
                Root.Left = NodeList.ElementAt(0);
                NodeList.RemoveAt(0);
                Root.Right = NodeList.ElementAt(0);
                NodeList.RemoveAt(0);

                NodeList.Add(Root);
                CreateTree();
            }

            

        }

        private void Encode(string text)
        {
            GetHuffmanCode(Root, ""); //fills the huffman codes dictionary with huffman tree
            foreach(char c in text)
            {
                DPIcodificated += HuffmanCodesDictionary[c];
            }
        }
        private void GetHuffmanCode(HuffmanNode node, string code)
        {
            if (node.TypeOfNode == 1)
            {
                //base case - leaf node with character
                HuffmanCodesDictionary.Add(node.Character, code);
                
            }
            else
            {
                if (node.Left != null)
                {
                   
                    GetHuffmanCode(node.Left, code += "0");
                    code = code.Remove(code.Length - 1);
                }
                
                if (node.Right != null)
                {
                    
                    GetHuffmanCode(node.Right, code += "1");
                    code = code.Remove(code.Length - 1);
                }
            }
        }

        public string DecodeText(string company)
        {
            string codificationAux = DPIcodificated;
            string output = "";

            while (codificationAux != "")
            {
                
                getCharacter(Root, ref codificationAux, ref output);
            }

            return output;
        }

        private void getCharacter(HuffmanNode node, ref string text, ref string output)
        {
           
            if (node.TypeOfNode == 1)
            {
                output += node.Character;
                return;
            }
            else if (text != "")
            {
                if (text[0] == '0')
                {
                    text = text.Remove(0,1);
                    getCharacter(node.Left, ref text, ref output);
                    return;
                }
                if (text[0] == '1')
                {
                    text = text.Remove(0,1);
                    getCharacter(node.Right, ref text, ref output);
                    return;
                }
            }

           
        }

    }
}
