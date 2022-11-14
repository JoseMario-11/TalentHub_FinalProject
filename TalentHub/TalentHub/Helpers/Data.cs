using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.Algorithm;

namespace TalentHub.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public Dictionary<string, string> DPICompanies = new Dictionary<string, string>();

        public Dictionary<string, Huffman> TreeCompanies = new Dictionary<string, Huffman>();

        public string Password = "DBDCJM22";

        public Applicant _Applicant;

        public string Company;
    }
}
