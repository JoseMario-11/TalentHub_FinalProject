using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHubApp
{
    public class Person
    {
        public string name { get; set; }
        public long dpi { get; set; }
        public DateTime datebirth { get; set; }
        public string address { get; set; }
        public string[] companies { get; set; }
        public string recluiter { get; set; }

        [NonSerialized]
        Dictionary<String, String> conversations = new Dictionary<String, String>();
    }
}
