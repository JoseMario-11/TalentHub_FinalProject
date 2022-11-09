using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHubLab1.Conversations;
using TalentHubLab1.RecommendationLetters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TalentHubLab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Applicant applicant = new Applicant();
        List<string> applicantFiles = new List<string>();
        public bool hasConv = false;
        

        public Form4(ref Applicant applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
            richTextBox1.Text = "";
            string filePath = @"C:\Users\jmmr1\OneDrive\Documentos\Systems Engeneering\2022\EstructuraDatos2\TalentHub\inputs";
            try
            {
                string[] fileEntries = Directory.GetFiles(filePath);
                hasConv = false;
                foreach (string fileName in fileEntries)
                {
                    if (fileName.Contains(applicant.DPI) && fileName.Contains("CONV"))
                    {
                        hasConv = true;
                        applicantFiles.Add(fileName);
                    }
                }
            }
            catch 
            {

            }
   
        }

        public void EncryptConversations(string Key)
        {
            foreach (string fileName in applicantFiles)
            {
                try
                {
                   
                    StreamReader sr = new StreamReader(fileName);
                    Conversation newConversation = new Conversation(sr.ReadToEnd(), Key);

                    int FileIndex = Convert.ToInt32(fileName.Substring(fileName.Length - 5, 1));
                    richTextBox1.Text += $"Conversation {FileIndex}:" + Environment.NewLine + Environment.NewLine;
                    if (!applicant.ConversationsInfo.Keys.Contains(FileIndex))
                    {
                        applicant.ConversationsInfo.Add(FileIndex, newConversation);
                        richTextBox1.Text += applicant.ConversationsInfo[FileIndex].Encrypt() + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        richTextBox1.Text += applicant.ConversationsInfo[FileIndex].EncryptedConversation + Environment.NewLine + Environment.NewLine;
                    }

                }
                catch
                {
                    MessageBox.Show("Error in encryption process");
                }


            }
        }

        public void DecryptConversations(string Key)
        {
            foreach (string fileName in applicantFiles)
            {
                try
                {
                    int FileIndex = Convert.ToInt32(fileName.Substring(fileName.Length - 5, 1));
                    richTextBox2.Text += $"Conversation {FileIndex}:" + Environment.NewLine + Environment.NewLine;
                    if (!applicant.ConversationsInfo.Keys.Contains(FileIndex))
                    {
                        richTextBox2.Text += applicant.ConversationsInfo[FileIndex].Decrypt() + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        richTextBox2.Text += applicant.ConversationsInfo[FileIndex].Decrypt() + Environment.NewLine + Environment.NewLine;
                    }
                }
                catch
                {
                    MessageBox.Show("Error in decryption process");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            if (textBox1.Text != "" && Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]+$"))
            {
                if (applicant.EncryptPassword == "" || (applicant.EncryptPassword != "" && applicant.EncryptPassword == textBox1.Text.Trim().ToLower()))
                {
                    if (hasConv)
                    {
                        applicant.EncryptPassword = textBox1.Text.Trim().ToLower();
                        EncryptConversations(applicant.EncryptPassword);
                        DecryptConversations(applicant.EncryptPassword);
                    }

                    else
                    {
                        richTextBox1.Text = $"Sorry, {applicant.Name} does not have conversations";

                    }
                }
                else
                {
                    MessageBox.Show("Error, incorrect key");
                }

            }
            else
            {
                MessageBox.Show("Error, invalid key");
            }
             
        }
    }
}
