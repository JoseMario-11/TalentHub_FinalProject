using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHubLab1.RecommendationLetters
{
    public class Code
    {
        public int index;
        public char character;

        public Code(char character)
        {
            this.character = character;
            index = 0;
        }

        public Code(int index, char character)
        {
            this.index = index;
            this.character = character;
        }
    }
}
