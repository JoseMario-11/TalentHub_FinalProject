using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using TalentHub.Huffman;
//using TalentHub.RecommendationLetters;
//using TalentHub.Conversations;

namespace TalentHub
{
    public class Applicant
    {
        
        public string Name { get; set; }
        public string DPI { get; set; }
        public string DateBirth { get; set; }
        public string Address { get; set; }
        public string[] Companies { get; set; }

        public string Recluiter { get; set; } 
        
        //[NonSerialized]

        //public Dictionary<int, Conversation> ConversationsInfo = new Dictionary<int, Conversation>();

       // [NonSerialized]

       // public string EncryptPassword = "";
    }
}
