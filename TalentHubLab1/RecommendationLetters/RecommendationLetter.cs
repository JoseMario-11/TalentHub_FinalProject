using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHubLab1.RecommendationLetters
{
    public class RecommendationLetter
    {
        public string OriginalContent;
        public string AuxText;
        public int EntriesCount;
        public Dictionary<string, int> EntryDictionary;
        public Dictionary<int, Code> EncodingDictionary;

        public RecommendationLetter(string OriginalText)
        {
            OriginalContent = OriginalText.Trim().ToLower();
            AuxText = OriginalContent;
            EntryDictionary = new Dictionary<string, int>();
            EncodingDictionary = new Dictionary<int, Code>();
            EntriesCount = 0;

        }


        public void Encoding()
        {
            string currentPrefix = "";
            for (int i = 0; i < OriginalContent.Length; i++)
            {
                if (SearchEntryKey(currentPrefix + OriginalContent[i]))
                {
                    currentPrefix += OriginalContent[i]; //increses the current prefix if the previous sequence is present in the dictionary

                    if (i == OriginalContent.Length - 1)
                    {
                        Code newCode = new Code(GetDictionaryIndex(currentPrefix), '~');  //end of file
                        EntryDictionary.Add("~", ++EntriesCount);
                        EncodingDictionary.Add(EntriesCount, newCode);
                        currentPrefix = "";
                    }
                }                   
                else
                {
                     Code newCode = new Code(GetDictionaryIndex(currentPrefix), OriginalContent[i]);  //currentPrefix[currentPrefix.Length - 1]
                     EntryDictionary.Add(currentPrefix + OriginalContent[i], ++EntriesCount);
                     EncodingDictionary.Add(EntriesCount, newCode);
                     currentPrefix = "";
                }
            }
        }


        public string Decode(int index)
        {
            string output = "";
            for (int i = 0; i <EncodingDictionary.Keys.Count; i++)
            {
                Code code = EncodingDictionary[i + 1];
                output += getSequence(code);
            }

            return output;
        }

        public string getSequence(Code code)
        {
            if (code.index == 0)
                return code.character + "";
            else
            {
                if (code.character == '~')
                    return getSequence(EncodingDictionary[code.index]);
               else
                    return getSequence(EncodingDictionary[code.index]) + code.character;
            } 
        }

        public bool SearchEntryKey(string substring)
        {
            return (EntryDictionary.Keys.Contains(substring)) ? true : false;
        }          

        public int GetDictionaryIndex(string currentPrefix)
        {

            return (EntryDictionary.Keys.Contains(currentPrefix)) ? EntryDictionary[currentPrefix] : 0;

        }
    }
}
