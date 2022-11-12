using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using TalentHub.AVL;
using TalentHub.Helpers;
using TalentHub.Algorithm;
using TalentHub.Algorithm.DES;

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
                            AVL.Delete(AVL.Root, applicant);
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
                    Data.Instance.DPICompanies[companie] = Data.Instance.DPICompanies[companie] + applicant.DPI;
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

        private void bImportFiles_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string compressed = Data.Instance.TreeCompanies["Gleichner and Sons"].CodeMessage("3050203740117");
            string descompressed = Data.Instance.TreeCompanies["Gleichner and Sons"].DecodingMessage(compressed);

            MessageBox.Show("El resultado comprimido es:" + Operation.binaryToString(compressed));
            MessageBox.Show("El resultado descomprimido es: " + descompressed);
        }
    }
}
