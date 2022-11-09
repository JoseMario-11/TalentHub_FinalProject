using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHubLab1.Huffman
{
    public class HuffmanNode
    {
        public  char Character { get; set; }
        public int Frequency { get; set; }
        public int TypeOfNode { get; set; } // 1 = leaf node || 0 = father node

        public HuffmanNode Right;
        
        public HuffmanNode Left;

        public HuffmanNode(int Frequency) //father node constructor
        {
            this.Frequency = Frequency;
            TypeOfNode = 0;
        }

        public HuffmanNode(char Character, int Frequency) //leaf node constructor
        {
            this.Character = Character;
            this.Frequency = Frequency;
            TypeOfNode = 1;
        }

    }
}
