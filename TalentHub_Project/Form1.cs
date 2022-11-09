using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TalentHub_Project.Helpers;
using ClassLibrary.POO;
using ClassLibrary.CODING;
using System.Text.Json;
using System.Text.RegularExpressions;
using ClassLibrary.DES;

namespace TalentHub_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] prueba = RSA.getKeys();
        }

        private void bUploadRecords_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "csv files (*.csv)|*.csv";
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;
            int insertCount = 0, patchCount = 0, deleteCount = 0;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                var filePath = OFD.FileName;
                var fileStream = OFD.OpenFile();

                try
                {
                    StreamReader csv = new StreamReader(filePath);
                    string line = csv.ReadLine();
                    string[] instruction;
                    do
                    {
                        instruction = line.Split(';');
                        Recruit recruit = JsonSerializer.Deserialize<Recruit>(instruction[1]);

                        if (recruit.companies.Length != 0)
                        {
                            for (int i = 0; i < recruit.companies.Length; i++)
                            {
                                if (!recruit.Coding.ContainsKey(recruit.companies[i]))
                                {
                                    Huffman coding = new Huffman(recruit.dpi + recruit.companies[i]);
                                    recruit.Coding.Add(recruit.companies[i], coding);
                                }

                                // Generación de las llaves públicas y privadas de los reclutadores por empresa
                                string relation = recruit.recluiter + recruit.companies[i];
                                if (!Data.Instance.recluiterCompany.ContainsKey(relation))
                                {
                                    int[] keys = RSA.getKeys();
                                    Data.Instance.recluiterCompany.Add(relation, keys);
                                }
                            }
                        }
                        if (instruction[0] == "INSERT")
                        {
                            Data.Instance.ReclutasName.Insert(recruit);
                            Data.Instance.ReclutasDPI.Insert(recruit);
                            insertCount++;
                        }
                        else if (instruction[0] == "DELETE")
                        {
                            Data.Instance.ReclutasName.Remove(recruit);
                            Data.Instance.ReclutasDPI.Remove(recruit);
                            deleteCount++;
                        }
                        else
                        {
                            string search = recruit.name + recruit.dpi;
                            Data.Instance.ReclutasName.Update(search, recruit);
                            Data.Instance.ReclutasDPI.Update(recruit.dpi, recruit);
                            patchCount++;
                        }
                        line = csv.ReadLine();
                    } while (line != null);
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.");
                }
                MessageBox.Show(String.Format("Se ha ingresado {0} registro(s)\n" +
                    "Se ha modificado {1} registro(s)\n" +
                    "Se ha eliminado {2} registro(s)\n" +
                    "Se ha cargado {3} registros en total",insertCount.ToString(),patchCount.ToString(),deleteCount.ToString(),Data.Instance.ReclutasDPI.Count), "Carga de reclutas");
                fileStream.Close();
            }
        }

        private void bUploadLetters_Click(object sender, EventArgs e)
        {
            List<string> files = FileOperations.getFiles();

            foreach (var filepath in files)
            {
                Regex[] regularExpressions = { new Regex(@"REC-\d+.-\d+"), new Regex(@"^REC-"), new Regex(@"-\d+$"), new Regex(@"\d+$"), new Regex(@"\d{13}") };

                string[] data = FileOperations.getData(filepath, regularExpressions);

                if (data != null)
                {
                    var recruit = Data.Instance.ReclutasDPI.Find(data[0]);
                    if (recruit != null)
                    {
                        string letter = File.ReadAllText(filepath);
                        LZ78 code = new LZ78();
                        recruit.LettersCoding.Add(Convert.ToInt32(data[1]), code.Encoding(letter));
                    }
                }
            }
        }

        private void bSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tBSearchName.Text;
                if (name == "")
                {
                    MessageBox.Show("No se ha ingresado ningún valor para la búsqueda de registros.");
                }
                else
                {
                    var registros = Data.Instance.ReclutasName.FindAll(name);

                    Stream stream;
                    SaveFileDialog SFD = new SaveFileDialog();
                    SFD.Filter = "txt files (*.txt)|*.txt";
                    SFD.FilterIndex = 2;
                    SFD.RestoreDirectory = true;

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        if ((stream = SFD.OpenFile()) != null)
                        {
                            StreamWriter writer = new StreamWriter(stream);
                            while (registros.Count > 0)
                            {
                                string recluta = JsonSerializer.Serialize<Recruit>(registros.Dequeue());
                                writer.WriteLine(recluta);
                            }
                            writer.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha guardado el archivo con los registros.");
                    }
                }
                tBSearchName.Text = "";
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado.");
            }
        }

        private void bSearchLetter_Click(object sender, EventArgs e)
        {
            try
            {
                string DPI = mTBSearchLetters.Text;
                Regex regexDPI = new Regex(@"^\d{13}$");
                if (regexDPI.IsMatch(DPI))
                {
                    var recruit = Data.Instance.ReclutasDPI.Find(DPI);
                    if (recruit != null)
                    {
                        CodingLetters codingLettersFrom = new CodingLetters(recruit);
                        codingLettersFrom.Show();
                    }
                    else
                    {
                        mTBSearchLetters.Text = "";
                        MessageBox.Show("No se ha encontrado un recluta registrado con el DPI consultado.");
                    }
                }
                else
                {
                    MessageBox.Show("El DPI ingresado no es válido.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido algún error inesperado.");
            }
        }

        private void nSearchDPI_Click(object sender, EventArgs e)
        {
            try
            {
                string dpi;
                if (mTBSearchDPI.Text != "")
                {
                    dpi = mTBSearchDPI.Text;
                    Recruit recruit = Data.Instance.ReclutasDPI.Find(dpi);
                    if (recruit != null)
                    {
                        CodingDPI condingDPIForm = new CodingDPI(recruit);
                        condingDPIForm.Show();
                    }
                    else
                    {
                        mTBSearchDPI.Text = "";
                        MessageBox.Show("No se ha encontrado ningún recluta con ese DPI registrado", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha ingresado un DPI para buscar.", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido algún error inesperado.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string key = "";
            do
            {
                key = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña para el cifrado del sistema: ", "Bienvenido");
                if (key.Length != 8)
                {
                    MessageBox.Show("La contraseña del sitema debe ser de 8 caracteres.", "Error");
                }
            } while (key.Length != 8);
            Data.Instance.key = key;
        }

        private void bConversationsDPI_Click(object sender, EventArgs e)
        {
            try
            {
                string dpi;
                if (mTBConversationsDPI.Text != "")
                {
                    dpi = mTBConversationsDPI.Text;
                    Recruit recruit = Data.Instance.ReclutasDPI.Find(dpi);
                    if (recruit != null)
                    {
                        CryptedConversations cryptedConversationsForm = new CryptedConversations(recruit);
                        cryptedConversationsForm.Show();
                    }
                    else
                    {
                        mTBConversationsDPI.Text = "";
                        MessageBox.Show("No se ha encontrado ningún recluta con ese DPI registrado", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha ingresado un DPI para buscar.", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido algún error inesperado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Authentication authenticationForm = new Authentication();
                authenticationForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido algún error inesperado, " + ex.Message);
            }
        }
    }
}
