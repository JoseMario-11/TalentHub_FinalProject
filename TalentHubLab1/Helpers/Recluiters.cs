using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TalentHubLab1.Helpers
{
    public class Recluiters
    {
        public Dictionary<string, List<string>> Dict = new Dictionary<string, List<string>>(); //key = recruiter's name, value = list with company names associated with the recruiter
        public Dictionary<string, List<Company>> DictKeys = new Dictionary<string, List<Company>>();

        public void InsertInfo(List<Applicant> applicantList)
        {
            foreach (Applicant applicant in applicantList)
            {
                if (!Dict.ContainsKey(applicant.Recluiter))
                {
                    Dict.Add(applicant.Recluiter, new List<string>());
                    DictKeys.Add(applicant.Recluiter, new List<Company>());
                }

                foreach(string company in applicant.Companies)
                {
                    if (!Dict[applicant.Recluiter].Contains(company))
                    {
                        Dict[applicant.Recluiter].Add(company);
                        DictKeys[applicant.Recluiter].Add(new Company(company));
                    }    
                }
            }
        }
        
    }
}
