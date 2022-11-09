using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHubLab1.AVL;
using TalentHubLab1.Huffman;

namespace TalentHubLab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Applicant Applicant = new Applicant();
        public Form2(ref Applicant applicant)
        {
            InitializeComponent();
            Applicant = applicant;
            textBox1.Text = $"{applicant.Name}   -   {applicant.DateBirth}   -   {applicant.Address}";

            /*
            foreach(string company in Applicant.Companies)
            {
                if (!Applicant.CompanyApplicantInfo.Keys.Contains(company))
                {
                    string CodificationText = company.Replace(" ", "").Replace("-", "").Replace("'", "") + Applicant.DPI;

                    //creation of a huffman tree and codification of the string
                    HuffmanTree Tree = new HuffmanTree();
                    Tree.CreateTree(CodificationText);
                    Applicant.CompanyApplicantInfo.Add(company, Tree);

                    richTextBox1.Text += $"{company}  -  {Applicant.CompanyApplicantInfo[company].DPIcodificated}" + Environment.NewLine;
                }
                
            }*/

            Codification();
            PrintCodification();
            int x = 1;
        }

        public void Codification()
        {
            foreach (string company in Applicant.Companies)
            {
                if (!Applicant.CompanyApplicantInfo.Keys.Contains(company))
                {
                    string CodificationText = company.Replace(" ", "").Replace("-", "").Replace("'", "").ToLower() + Applicant.DPI;

                    //creation of a huffman tree and codification of the string
                    HuffmanTree Tree = new HuffmanTree();
                    Tree.CreateTree(CodificationText);
                    Applicant.CompanyApplicantInfo.Add(company, Tree);
                }

            }
        }

        public void PrintCodification()
        {
            foreach (string company in Applicant.Companies)
            {
                richTextBox1.Text += $"{company}  -  {Applicant.CompanyApplicantInfo[company].DPIcodificated}" + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string company in Applicant.Companies)
            {
                string decodeText = Applicant.CompanyApplicantInfo[company].DecodeText(company);
                richTextBox2.Text += $"{company}   -   {decodeText.Replace(company.Replace(" ", "").Replace("-", "").Replace("'", "").ToLower(), "")}" + Environment.NewLine;
            }
        }
    }
}
