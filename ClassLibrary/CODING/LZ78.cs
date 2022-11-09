using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CODING
{
    public class SingularCode
    {
        public int i { get; set; }
        public char? Character { get; set; }

        public SingularCode(int position, char? character)
        {
            i = position;
            Character = character;
        }
    }

    public class LZ78
    {
        public Dictionary<int,SingularCode> Encoding(string message)
        {
            Dictionary<int, SingularCode> output = new Dictionary<int, SingularCode>();
            Dictionary<string, int> table = new Dictionary<string, int>();
            int j = 1;
            bool verification = true;
            char? character;

            do
            {
                int i = 0;
                string combination = "";
                combination += message[0].ToString();
                character = message[0];
                if (message.Length > 1)
                {
                    message = message.Substring(1);
                }
                else
                {
                    message = "";
                }

                while (table.ContainsKey(combination) && verification)
                {
                    i = table[combination];
                    if (message != "")
                    {
                        combination += message[0].ToString();
                        if (message.Length > 1)
                        {
                            character = message[0];
                            message = message.Substring(1);
                        }
                        else
                        {
                            character = message[0];
                            message = "";
                        }
                    }
                    else
                    {
                        combination += "EOF";
                        character = null;
                        verification = false;
                    }
                }
                table.Add(combination, j);
                var code = new SingularCode(i, character);
                output.Add(j,code);
                j++;
            } while (message.Length > 0);

            return output;
        }

        public string Decoding (Dictionary<int, SingularCode> code)
        {
            string output = "";
            for (int i = 1; i <= code.Count; i++)
            {
                string aux = code[i].Character.ToString();
                int j = i;
                while (code[j].i != 0)
                {
                    j = code[j].i;
                    aux += code[j].Character.ToString();
                }
                
                output += Reverse(aux);
            }
            return output;
        }

        string Reverse(string message)
        {
            string output = "";
            for (int i = message.Length; i > 0; i--)
            {
                output += message[i - 1].ToString();
            }
            return output;
        }
    }
}
