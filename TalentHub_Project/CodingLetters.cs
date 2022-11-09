using ClassLibrary.CODING;
using ClassLibrary.POO;
using System;
using System.Windows.Forms;

namespace TalentHub_Project
{
    public partial class CodingLetters : Form
    {
        public Recruit RecruitSearch;

        public CodingLetters(Recruit recruit)
        {
            RecruitSearch = recruit;
            InitializeComponent();
        }

        private void bDecodingLetters_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rTBLettersDecoding.Visible)
                {
                    foreach (var letter in RecruitSearch.LettersCoding)
                    {
                        string message = "";
                        message += "Carta: " + letter.Key + "\n";
                        LZ78 algorithim = new LZ78();
                        message += algorithim.Decoding(letter.Value) + "\n\n";
                        rTBLettersDecoding.Text += message;
                    }
                    bDecodingLetters.Text = "Ocultar cartas";
                    rTBLettersDecoding.Visible = true;
                }
                else
                {
                    bDecodingLetters.Text = "Mostrar cartas";
                    rTBLettersDecoding.Text = "";
                    rTBLettersDecoding.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrico algún error inesperado.");
            }
        }

        private void CodingLetters_Load(object sender, EventArgs e)
        {
            lRecruitInformation.Text = String.Format("Nombre: {0}\nDpi: {1}", RecruitSearch.name, RecruitSearch.dpi);
            foreach (var letter in RecruitSearch.LettersCoding)
            {
                rTBLettersCoding.Text += "Carta " + letter.Key.ToString() + "\n";
                string codeLetter = "";
                foreach (var coding in letter.Value)
                {
                    codeLetter += String.Format("<{0},{1}> ", coding.Value.i.ToString(), coding.Value.Character.ToString());
                }
                rTBLettersCoding.Text += (codeLetter + "\n\n");
            }
        }
    }
}
