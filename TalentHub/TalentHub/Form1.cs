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
using TalentHub.Algorithm.RSA;
using TalentHub.Algorithm.DES;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace TalentHub
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            actualPage = tPDataEntry;
        }

        //Elements used to open a .csv file with information about applicant records
        OpenFileDialog pathSearcher = new OpenFileDialog();
        FileStream file;
        StreamReader read;
        public AVLclass AVL = new AVLclass();
        public Recluiters Rec = new Recluiters();
        public SHA256 alg = SHA256.Create();
        public bool inProcess = false;
        public TabPage actualPage;

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

            Applicant prueba = new Applicant();
            prueba.Address = "no se";
            prueba.Companies = new string[]{ "Hane and Sons","Littel   Dickinson"};
            prueba.DPI = "3050203740117";
            prueba.DateBirth = "04/11/2002";
            prueba.Recluiter = "Owen Corwin";
            AVL.Insert(AVL.Root, prueba);
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
                AVL.getAll(AVL.Root);
                Rec.InsertInfo(AVL.AllApplicantList);

                //foreach (string recluiter in Rec.Dict.Keys)
                //{
                //    cBReluiter.Items.Add(recluiter);
                //}

                file.Close();
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
                long DPI = Convert.ToInt64(tBLettersDPI.Text);
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

                    btnDecompress.Enabled = false;
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
                        File.WriteAllText(FileName, Algorithm.DES.DES.encrypt(text, Data.Instance.Password));   //Create file
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
                rTBConversations.Text = "";
                if (tBConversationsDPI.Text == "")
                {
                    MessageBox.Show("No ha ingresado ningún DPI");
                }
                else
                {
                    string dpi = tBConversationsDPI.Text;
                    List<string> conversations = new List<string>();

                    if (AVL.SearchByDPI(AVL.Root, dpi) == null)
                    {
                        MessageBox.Show("No se ha encontrado a ningún recluta con ese DPI.");
                    }
                    else
                    {
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
                                textConversations += (string.Format("Conversación Núm.{0}:\n{1}\n\n", i.ToString(), Algorithm.DES.DES.decrypt(text, Data.Instance.Password)));
                            }
                            else
                            {
                                textConversations += (string.Format("Conversación Núm.{0}:\n{1}", i.ToString(), Algorithm.DES.DES.decrypt(text, Data.Instance.Password)));
                            }
                            i++;
                        }

                        rTBConversations.Text = textConversations;
                        bShowConversations.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un fallo: no se ha podido completar la operación:\n" + ex.Message, "Error");
            }
        }


        private void bVerifyCompany_Click(object sender, EventArgs e)
        {
            if (Data.Instance.Company != "")
            {
                byte[] data = Encoding.ASCII.GetBytes(Data.Instance.Company);
                byte[] hash = alg.ComputeHash(data);

                RSAParameters sharedParameters;
                byte[] signedHash;


                //Signature generation
                using (RSA rsa = RSA.Create())
                {
                    sharedParameters = rsa.ExportParameters(true);

                    RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm(nameof(SHA256));

                    signedHash = rsaFormatter.CreateSignature(hash);
                }

                // Signature verification

                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportParameters(sharedParameters);

                    RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm(nameof(SHA256));

                    if (rsaDeformatter.VerifySignature(hash, signedHash))
                    {
                        string company = Data.Instance.Company;
                        string dpi = Data.Instance._Applicant.DPI;
                        string code = Data.Instance.TreeCompanies[company].CodeMessage(Data.Instance._Applicant.DPI);
                        if (code.Length % 8 != 0)
                        {
                            int count = ((code.Length / 8) + 1) * 8;
                            code = code.PadLeft(count, '0');
                        }

                        string codeDPI = Operation.binaryToString(code);
                        
                        MessageBox.Show("Firma de la empresa correctamente verificada, proceso finalizado");
                        MessageBox.Show(string.Format("¡Felicidades {0}!,\nSe ha contactado correctamente con un recluta que puede cumplir con las expectativas del puesto de trabajo que tiene disponible.\n\n" +
                            "Aquí su información de contacto:\n\n" +
                            "Nombre: {1}\n" +
                            "DPI (protegido): {2}\n" +
                            "Fecha de nacimiento: {3}\n\n" +
                            "Recluta que llevó el proceso: {4}", company, Data.Instance._Applicant.Name, codeDPI,
                            Data.Instance._Applicant.DateBirth, Data.Instance._Applicant.Recluiter));
                    }
                    else
                    {
                        MessageBox.Show("Error en la verificación de la identidad de la empresa");
                    }
                }

                actualPage = tPDataEntry;
                inProcess = false;
                Data.Instance._Applicant = null;
                Data.Instance.Company = "";
                tCMenu.SelectedTab = tPDataEntry;
            }
        }

        private void bWatchConversations_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("cipher-conversation"))
            {
                Process.Start("explorer.exe", "cipher-conversation");
            }
            else
            {
                MessageBox.Show("Aún no hay conversaionescargadas al sistema.");
            }
        }



        private void bSearchApplicant_Click(object sender, EventArgs e)
        {
            try
            {
                cBCompanie.Enabled = false;
                rTBApplicantInformation.Text = "";
                Data.Instance._Applicant = null;
                if (mTBApplicantDPI.Text == "")
                {
                    MessageBox.Show("No ha ingresado ningún DPI para iniciar un proceso de recultamiento.");
                    mTBApplicantDPI.Text = "";
                }
                else
                {
                    string dpi = mTBApplicantDPI.Text;
                    Applicant applicant = AVL.SearchByDPI(AVL.Root, dpi);
                    if (applicant == null)
                    {
                        MessageBox.Show("El DPI ingresado no se encuentra registrado en el sistema.", "Error");
                        mTBApplicantDPI.Text = "";
                    }
                    else
                    {
                        Data.Instance._Applicant = applicant;
                        string infoApplicant = string.Format("Nombre: {0}\tDPI: {1}\nReclutador: {2}", applicant.Name, applicant.DPI, applicant.Recluiter);

                        tBSelectedRecluiter.Text = applicant.Recluiter;
                        rTBApplicantInformation.Text = infoApplicant;
                        cBCompanie.Enabled = true;
                        bStartRecluitProcess.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido finalizar el proceso, ha ocurrido un error.\n" + ex.Message, "Error");
            }
        }

        private void tBSelectedRecluiter_TextChanged(object sender, EventArgs e)
        {
            cBCompanie.Items.Clear();
            cBCompanie.Text = "";
            List<string> companies = new List<string>();
            if (tBSelectedRecluiter.Text != "")
            {
                foreach (var company in Data.Instance._Applicant.Companies)
                {
                    companies.Add(company);
                }

                foreach (string company in Rec.Dict[tBSelectedRecluiter.Text])
                {
                    if (companies.Contains(company))
                    {
                        cBCompanie.Items.Add(company);
                    }
                }
            }
        }

        private void bStartRecluitProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBCompanie.SelectedIndex == -1)
                {
                    MessageBox.Show("Error: no puede iniciar el proceso de reclutamiento si no ha especificado una compañia.\nPor favor seleccionar una compañía.", "Error");
                }
                else
                {
                    Data.Instance.Company = cBCompanie.Text;
                    inProcess = true;
                    actualPage = tPResolution;
                    tCMenu.SelectedTab = tPResolution;
                    tBConversationsDPI.Text = Data.Instance._Applicant.DPI;
                    tBLettersDPI.Text = Data.Instance._Applicant.DPI;
                    mTBApplicantDPI.Text = "";
                    rTBApplicantInformation.Text = "";
                    tBSelectedRecluiter.Text = "";
                    bNextResolutionPage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido finalizar el proceso: ha ocurrido un error.\n" + ex.Message, "Error");
            }
        }

        private void tCMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inProcess)
            {
                if (tCMenu.SelectedTab == tPDataEntry || tCMenu.SelectedTab == tPImportFiles || tCMenu.SelectedTab == tPStartProcess)
                {
                    MessageBox.Show("Esta función no está habilitada en este momento");
                    tCMenu.SelectedTab = actualPage;
                }
                else
                {
                    if (tCMenu.SelectedTab != actualPage)
                    {
                        MessageBox.Show("Debe continuar con el flujo del proceso actual");
                        tCMenu.SelectedTab = actualPage;
                    }
                }
            }
            else
            {
                if (tCMenu.SelectedTab == tPConversations || tCMenu.SelectedTab == tPRecommendationLetters || tCMenu.SelectedTab == tPCompleteProcess || tCMenu.SelectedTab == tPResolution)
                {
                    MessageBox.Show("Esta función no está habilitada en este momento");
                    tCMenu.SelectedTab = tPStartProcess;
                }
            }
        }

        private void bNextConversationPage_Click(object sender, EventArgs e)
        {
            tBConversationsDPI.Text = "";
            rTBConversations.Text = "";
            bNextConversationPage.Enabled = false;
            bNextRecomendationPage.Enabled = true;
            actualPage = tPRecommendationLetters;
            tCMenu.SelectedTab = tPRecommendationLetters;
        }

        private void bNextResolutionPage_Click(object sender, EventArgs e)
        {
            try
            {
                string dpi = Data.Instance._Applicant.DPI;
                bool vConversation = false, vRecomendation = false;

                foreach (string file in Directory.EnumerateFiles("cipher-conversation", "*.txt"))
                {
                    if (file.Contains(dpi))
                    {
                        vConversation = true;
                        break;
                    }
                }
                foreach (string file in Directory.EnumerateFiles("encoded-inputs", "*.txt"))
                {
                    if (file.Contains(dpi))
                    {
                        vRecomendation = true;
                        break;
                    }
                }

                if (!vConversation || !vRecomendation)
                {
                    MessageBox.Show("El candidato no ha cumplido con los requisitos mínimos. Será eliminado del sistema");
                    AVL.Remove(Data.Instance._Applicant);
                    Data.Instance._Applicant = null;
                    inProcess = false;
                    tCMenu.SelectedTab = tPStartProcess;
                }
                else
                {
                    MessageBox.Show("Enhorabuena, el candidato ha cumplido con los requisitos mínimos para continuar su proceso de contratación en Talent hub");
                    bNextResolutionPage.Enabled = false;
                    bNextConversationPage.Enabled = true;
                    actualPage = tPConversations;
                    tCMenu.SelectedTab = tPConversations;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido completar el proceso: ha ocurrido un error inesperado." +  ex.Message, "Error");
            }
        }

        private void bNextRecomendationPage_Click(object sender, EventArgs e)
        {
            rTBLetters.Text = "";
            tBLettersDPI.Text = "";
            bNextRecomendationPage.Enabled = true;
            bVerifyCompany.Enabled = true;
            actualPage = tPCompleteProcess;
            tCMenu.SelectedTab = tPCompleteProcess;
        }
    }
}
