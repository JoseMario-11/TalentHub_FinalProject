using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Algorithm
{
    public class LZW
    {
        public string Compress(string Input)
        {

            Dictionary<string, int> MainDict = new Dictionary<string, int>();
            List<int> Output = new List<int>();

            FillDictionary(ref MainDict);

            char[] chtr = Input.ToCharArray();      //Create a char array with the input string
            List<char> chtrList = chtr.ToList();
            string pair;

            int ValueDict = 256;        //This value will increment while adding elements on dictionary

            while (chtrList.Count > 0)
            {
                if (chtrList.Count() > 1)
                {
                    pair = chtrList[0].ToString() + chtrList[1].ToString(); //Obtain pair of chars

                    if (!MainDict.ContainsKey(pair))  //Evaluate if main dictionary contains the specified pair of chars
                    {
                        MainDict.Add(pair, ValueDict);      //Add pair of chars to dictionary
                        ValueDict++;                        //Increment dictionary's key value
                        Output.Add(MainDict[Convert.ToString(chtrList[0])]);       //Add the first char's key value to output list
                        chtrList.RemoveAt(0);
                    }
                    else
                    {
                        int count = 2;
                        string aux = pair;
                        bool flag = true;

                        while (MainDict.ContainsKey(pair))      //While main dictionary contains the pair of chars, do:
                        {
                            if (count < chtrList.Count())        //Control count's value
                            {
                                aux = pair;             //Use aux to save pair's content
                                pair += Convert.ToString(chtrList[count]);  //Concatenate the new char with the previous pair of chars
                                count++;                //Increment count if next iteration while == true
                            }
                            else
                            {
                                flag = false;       //If count is equals, or higher than char.length, use flag
                                break;
                            }
                        }

                        if (flag)
                        {
                            MainDict.Add(pair, ValueDict);  //Add new string to main dictionary
                            ValueDict++;                    //Increment dictionary's key value


                        }

                        chtrList.RemoveRange(0, count - 1);
                        Output.Add(MainDict[aux]);      //Add aux index of main dictionary to output
                    }
                }
                else
                {
                    Output.Add(MainDict[Convert.ToString(chtrList[0])]);       //Add the first char's key value to output list
                    chtrList.RemoveAt(0);
                }

            }
            return String.Join(",", Output.ToArray());

        }

        public string Decompress(List<int> compressed)
        {
            Dictionary<int, string> MainDict = new Dictionary<int, string>();


            for (int i = 0; i < 256; i++)       //265 ASCII Characters
            {
                char x = (char)(i);    //Add 31 to (i) because desired ASCII characters start at ASCII code 32
                MainDict.Add(i, x.ToString());  //Add chars to dictionary, starting at pos 1
            }
            string w = MainDict[compressed[0]];
            compressed.RemoveAt(0);
            StringBuilder decompressed = new StringBuilder(w);
            foreach (int k in compressed)
            {
                string entry = null;
                if (MainDict.ContainsKey(k))
                    entry = MainDict[k];
                else if (k == MainDict.Count)
                    entry = w + w[0];

                decompressed.Append(entry);

                // new sequence; add it to the dictionary
                MainDict.Add(MainDict.Count, w + entry[0]);

                w = entry;
            }

            return decompressed.ToString();
        }

        public void FillDictionary(ref Dictionary<string, int> MainDict)
        {
            for (int i = 0; i < 256; i++)       //265 ASCII Characters
            {
                char x = (char)(i);    //Add 31 to (i) because desired ASCII characters start at ASCII code 32
                MainDict.Add(x.ToString(), i);  //Add chars to dictionary, starting at pos 1
            }

        }

    }
}

