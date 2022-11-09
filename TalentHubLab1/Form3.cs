using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TalentHubLab1.RecommendationLetters;

namespace TalentHubLab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Applicant applicant = new Applicant();
        List<string> applicantFiles = new List<string>();

        public Form3(ref Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
            textBox1.Text = $"{applicant.Name}   -   {applicant.DateBirth}   -   {applicant.Address}";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            GetRecommendationLetters();
        }

        public void GetRecommendationLetters()
        {
            FolderBrowserDialog Fd = new FolderBrowserDialog();
            Fd.ShowNewFolderButton = true;
            if (Fd.ShowDialog() == DialogResult.OK)
            {
                //string folderName = Path.GetDirectoryName(Fd.SelectedPath);
                string[] fileEntries = Directory.GetFiles(Fd.SelectedPath);
                //List<string> applicantFiles = new List<string>();

                bool hasLetter = false;
                foreach (string fileName in fileEntries)
                {
                    if (fileName.Contains(applicant.DPI) && fileName.Contains("REC"))
                    {
                        hasLetter = true;
                        applicantFiles.Add(fileName);
                    }
                        
                }

                if (hasLetter)
                {
                    EncodeRecommendationLetters();
                    DecodeRecommendationLetters();
                }
                   
                else
                {
                    richTextBox1.Text = $"Sorry, {applicant.Name} does not have recommendation letters";
                    
                }
            }
        }

        public void EncodeRecommendationLetters()
        {
            foreach(string fileName in applicantFiles)
            {
                try
                {
                    StreamReader sr = new StreamReader(fileName);
                    RecommendationLetter newLetter = new RecommendationLetter(sr.ReadToEnd());
                    int FileIndex = Convert.ToInt32(fileName.Substring(fileName.Length - 5, 1));
                    applicant.RecommendationLettersInfo.Add(FileIndex, newLetter);

                    //encoding method call
                    applicant.RecommendationLettersInfo[FileIndex].Encoding();

                    richTextBox1.Text += $"Letter {FileIndex}:" + Environment.NewLine;
                    richTextBox1.Text += PrintEncoding(applicant.RecommendationLettersInfo[FileIndex].EncodingDictionary) + Environment.NewLine + Environment.NewLine;
                }
                catch
                {
                    MessageBox.Show("Error in encoding process");
                }
                

            }
        }

        public string PrintEncoding(Dictionary<int, Code> EncodingDictionary)
        {
            string output = "";
            foreach (var element in EncodingDictionary)
            {
                output += $"<{element.Value.index},{element.Value.character}>";
            }

            return output;
        }

        public void DecodeRecommendationLetters()
        {
            foreach(var letter in applicant.RecommendationLettersInfo)
            {
                richTextBox2.Text += $"Letter {letter.Key}: " + Environment.NewLine + Environment.NewLine;
                richTextBox2.Text += letter.Value.Decode(1) + Environment.NewLine + Environment.NewLine;
            }
        }

    }
}
