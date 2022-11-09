using System;
using System.Collections.Generic;
using ClassLibrary.CODING;

namespace ClassLibrary.POO
{
    public class Recruit
    {
        public string name { get; set; }

        public string dpi { get; set; }

        public DateTime datebirth { get; set; }

        public string address { get; set; }

        public string[] companies { get; set; }

        public string recluiter { get; set; }

        [NonSerialized]
        public Dictionary<string, Huffman> Coding = new Dictionary<string, Huffman>();

        [NonSerialized]
        public Dictionary<int, Dictionary<int, SingularCode>> LettersCoding = new Dictionary<int, Dictionary<int, SingularCode>>();
    }
}
