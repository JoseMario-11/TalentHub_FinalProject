using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using TalentHub.AVL;
using TalentHub.Helpers;
using TalentHub.Algorithm;
using TalentHub.Algorithm.DES;
using System.Text.RegularExpressions;

namespace TalentHub
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        //Elements used to open a .csv file with information about applicant records
        OpenFileDialog pathSearcher = new OpenFileDialog();
        FileStream file;
        StreamReader read;
        public AVLclass AVL = new AVLclass();


        // Function dedicated to convert a string into json format  
        public void JsonConverter(StreamReader file)
        {
            //while the end of the stream is not reached, take one line of the file content
            while (!file.EndOfStream)
            {
                string line = file.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    //array that contains the necessary instructions to create the AVL with all the applicant records
                    string[] instructions = line.Split(';');

                    //deserialize string with newtonsoft.json to create a new applicant element
                    Applicant applicant = JsonConvert.DeserializeObject<Applicant>(instructions[1]);

                    //the first position of the array indicates what kind of operation the AVL needs to do to generate its structure

                    switch (instructions[0].ToLower())
                    {
                        case "insert":
                            AVL.Root = AVL.Insert(AVL.Root, applicant);
                            break;
                        case "patch":
                            AVL.Edit(AVL.Root, applicant);
                            break;
                        case "delete":
                            AVL.Remove(applicant);
                            break;
                    }

                    //Update information to generate the code for compressed companie
                    UpdateCompanieInformation(applicant);
                }
            }
            //Inicialization of tree companies to compress DPI
            UpdateTreeCompanies();

        }

        private void UpdateCompanieInformation(Applicant applicant)
        {
            string[] companies = applicant.Companies;

            foreach (string companie in companies)
            {
                //The first time appear a companie
                if (!Data.Instance.DPICompanies.ContainsKey(companie))
                {
                    Data.Instance.DPICompanies.Add(companie, applicant.DPI);
                }
                else //A companie already exist and add more DPI recluiters
                {
                    Data.Instance.DPICompanies[companie] += applicant.DPI;
                }
            }
        }

        private void UpdateTreeCompanies()
        {
            foreach (var keyValuePair in Data.Instance.DPICompanies)
            {
                Huffman tree = new Huffman(keyValuePair.Value);
                //It's the first time that generate a tree for the companie
                if (!Data.Instance.TreeCompanies.ContainsKey(keyValuePair.Key))
                {
                    Data.Instance.TreeCompanies.Add(keyValuePair.Key, tree);
                }
                else //A tree alredy exist for the companie before, assign a new one
                {
                    Data.Instance.TreeCompanies[keyValuePair.Key] = tree;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pathSearcher.Filter = "CSV files |*.csv";
            if (pathSearcher.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = pathSearcher.FileName;
                file = new FileStream(pathSearcher.FileName, FileMode.OpenOrCreate);
                read = new StreamReader(file);
                JsonConverter(read);
            }
        }

        private void btnComprimirCartas_Click(object sender, EventArgs e)
        {
            string directory = "";

            using (var FBD = new FolderBrowserDialog())
            {
                DialogResult result = FBD.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FBD.SelectedPath))
                {
                    directory = FBD.SelectedPath;
                }
            }

            if (directory == "")
            {
                MessageBox.Show("Fallo al cargar archivos: no se ha seleccionado ningún directorio.", "Error");
            }
            else
            {
                List<string> Letters = new List<string>();
                Queue<string> dpi = new Queue<string>();

                Regex lValidation = new Regex(@"REC-\d+.-\d+");

                foreach (string file in Directory.EnumerateFiles(directory, "*.txt"))
                {
                    if (lValidation.IsMatch(file))
                    {
                        Letters.Add(File.ReadAllText(file)); //Add content of letter to list

                        Regex expression = new Regex(@"(?<=REC-)\d+");      //Get # DPI
                        var result = expression.Match(file);
                        dpi.Enqueue(Convert.ToString(result));          //Add DPI to list
                    }
                }

                List<string> EncodedLetters = new List<string>();

                if (!Directory.Exists("encoded-inputs"))
                {
                    Directory.CreateDirectory("encoded-inputs");    //Create folder
                }

                int counter = 1;
                foreach (string text in Letters)
                {
                    LZW encode = new LZW();     //Create a new instance for LZW
                    string xDpi = dpi.Peek();       //Take one of the DPIs on the queue
                    string FileName = @"encoded-inputs\" + "compressed-" + xDpi + "-" + counter.ToString() + ".txt";
                    File.WriteAllText(FileName, encode.Compress(text));   //Create file
                    dpi.Dequeue();

                    if (dpi.Count() != 0)       //Verify if queue is not empty
                    {
                        if (xDpi == dpi.Peek())
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                        }
                    }

                }
                MessageBox.Show("Se han comprimido todas las cartas de recomendación.");
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                rTBLetters.Clear();
                long DPI = Convert.ToInt64(mTBBuscarDPI.Text);
                bool verify = false;

                List<string> FilteredFiles = new List<string>();
                foreach (string file in Directory.EnumerateFiles("encoded-inputs", "*.txt"))    //Iterate all files from directory
                {
                    if (file.Contains(Convert.ToString(DPI)))
                    {
                        FilteredFiles.Add(File.ReadAllText(file));  //If file name contains the DPI, add to list
                        verify = true;
                    }
                }

                if (verify)
                {
                    List<string> scodes = new List<string>();   //List that will contain the string codes
                    List<int> codes = new List<int>();      //List that will contain one code for each position

                    string directoryName = "decompressed-inputs/REC-" + Convert.ToString(DPI);
                    if (!Directory.Exists("decompressed-inputs"))
                    {
                        Directory.CreateDirectory("decompressed-inputs");    //Create folder          
                    }
                    if (!Directory.Exists(directoryName))
                    {
                        Directory.CreateDirectory(directoryName);    //Create folder
                    }

                    int i = 1;

                    foreach (string compressed in FilteredFiles)
                    {
                        scodes = compressed.Split(',').ToList();    //Split codes by ','

                        foreach (string item in scodes)
                        {
                            codes.Add(Convert.ToInt32(item));       //Add each string to list, converting it to integer                
                        }

                        LZW lzw = new LZW();        //Create new LZW instance
                        string FileName = directoryName + "/" + "REC-" + Convert.ToString(DPI) + "-" + Convert.ToString(i) + ".txt";
                        string decompressedLetter = lzw.Decompress(codes);
                        File.WriteAllText(FileName, decompressedLetter);   //Create file;
                        rTBLetters.Text += decompressedLetter + "\n\n"; //**NEW**: ADD TO RICH TEXT BOX
                        scodes.Clear();
                        codes.Clear();
                        i++;
                    }

                    MessageBox.Show("Se han descomprimido las cartas de recomendación para el DPI: " + DPI.ToString());
                }
                else
                {
                    MessageBox.Show("No se han encontrado cartas de recomendación para el DPI ingresado.");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("ERROR: Ha ocurrido un problema con la descompresión. Por favor, reinicia el sistema.");
            }
        }

        private void btnWatchComp_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("encoded-inputs"))
            {
                Process.Start("explorer.exe", "encoded-inputs");
            }
            else
            {
                MessageBox.Show("La carpeta de cartas de recomendación comprimidas no existe aún.");
            }
        }

        private void bImportConversation_Click(object sender, EventArgs e)
        {
            try
            {
                string directory = "";

                try
                {
                    using (var FBD = new FolderBrowserDialog())
                    {
                        DialogResult result = FBD.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FBD.SelectedPath))
                        {
                            directory = FBD.SelectedPath;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al abrir los archivos." + ex.Message, "Error");
                }


                if (directory == "")
                {
                    MessageBox.Show("Fallo al cargar archivos: no se ha seleccionado ningún directorio.", "Error");
                }
                else
                {
                    List<string> conv = new List<string>();
                    Queue<string> dpi = new Queue<string>();

                    Regex convValidation = new Regex(@"CONV-\d+.-\d+");

                    foreach (string file in Directory.EnumerateFiles(directory, "*.txt"))
                    {
                        if (convValidation.IsMatch(file))
                        {
                            conv.Add(File.ReadAllText(file)); //Add content of letter to list

                            Regex expression = new Regex(@"(?<=CONV-)\d+");      //Get # DPI
                            var result = expression.Match(file);
                            dpi.Enqueue(Convert.ToString(result));          //Add DPI to list
                        }
                    }

                    if (!Directory.Exists("cipher-conversation"))
                    {
                        Directory.CreateDirectory("cipher-conversation");    //Create folder
                    }

                    int counter = 1;
                    foreach (string text in conv)
                    {
                        string xDpi = dpi.Peek();       //Take one of the DPIs on the queue
                        string FileName = @"cipher-conversation\" + "cipher-" + xDpi + "-" + counter.ToString() + ".txt";
                        File.WriteAllText(FileName, DES.encrypt(text, Data.Instance.Password));   //Create file
                        dpi.Dequeue();

                        if (dpi.Count() != 0)       //Verify if queue is not empty
                        {
                            if (xDpi == dpi.Peek())
                            {
                                counter++;
                            }
                            else
                            {
                                counter = 1;
                            }
                        }

                    }
                    MessageBox.Show("Se han importado todas las conversaciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido una fallo: no se ha podido completar la operación:\n" + ex.Message, "Error");
            }
        }

        private void bShowConversations_Click(object sender, EventArgs e)
        {
            try
            {
                if (mTBConversationsDPI.Text == "")
                {
                    MessageBox.Show("No ha ingresado ningún DPI");
                }
                else
                {
                    string dpi = mTBConversationsDPI.Text;
                    List<string> conversations = new List<string>();

                    foreach (string file in Directory.EnumerateFiles("cipher-conversation", "*.txt"))
                    {
                        if (file.Contains(dpi))
                        {
                            conversations.Add(File.ReadAllText(file)); //Add content of chipher conversation to list
                        }
                    }

                    string textConversations = ""; int i = 1;

                    foreach (string text in conversations)
                    {
                        if (i < conversations.Count)
                        {
                            textConversations += (string.Format("Conversación Núm.{0}:\n{1}\n\n", i.ToString(), DES.decrypt(text, Data.Instance.Password)));
                        }
                        else
                        {
                            textConversations += (string.Format("Conversación Núm.{0}:\n{1}", i.ToString(), DES.decrypt(text, Data.Instance.Password)));
                        }
                        i++;
                    }

                    rTBConversations.Text = textConversations;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un fallo: no se ha podido completar la operación:\n" + ex.Message, "Error");
            }
        }
    }
}
