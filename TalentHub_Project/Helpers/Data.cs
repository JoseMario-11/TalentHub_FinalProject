using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Structures;
using ClassLibrary.POO;

namespace TalentHub_Project.Helpers
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


        public AVL<Recruit, string> ReclutasName = new AVL<Recruit, string>((Recruit x, Recruit y) => (x.name + x.dpi).CompareTo(y.name + y.dpi), (string x, Recruit y) => x.CompareTo(y.name + y.dpi), (string x, Recruit y) => x.CompareTo(y.name));
        
        public AVL<Recruit, string> ReclutasDPI = new AVL<Recruit, string>((Recruit x, Recruit y) => (x.dpi).CompareTo(y.dpi), (string x, Recruit y) => x.CompareTo(y.dpi), (string x, Recruit y) => x.CompareTo(y.dpi));

        public string key;

        public List<string> Companies = new List<string>();
        
        // string[] = recluiter, companie
        // int[] = n, k, j
        public Dictionary<string, int[]> recluiterCompany = new Dictionary<string, int[]>();
    }
}
