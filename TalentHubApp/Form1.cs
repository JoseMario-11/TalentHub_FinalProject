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
using Newtonsoft.Json;
using System.Collections;
using System.Text.RegularExpressions;
using System.Numerics;

namespace TalentHubApp
{
    public partial class Form1 : Form
    {
        List<String> conversations = new List<String>();
        List<String> convDpI = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnImport_Click(object sender, EventArgs e)
        {
            string[] Data = new string[2];

            //Open File Dialog
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;

                GetData(file, Data);
                MessageBox.Show("Se ha agregado la información del archivo CSV correctamente en la estructura de datos.");
                tBSource.Text = file;
                gBImportar.Enabled = false;
                /*gBEncriptar.Enabled = true;
                gBBuscar.Enabled = true;*/
                tabControl1.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR: No se ha podido abrir el archivo correctamente");
            }
        }

        public void GetData(string file, string[] data)
        {
            //Reads data in each line and make the needed operation in the tree
            foreach (string line in File.ReadLines(file))
            {
                data = line.Split(';');

                if (data[0].Contains("INSERT"))
                {
                    InsertJSON(data[1]);
                }
                else if (data[0].Contains("PATCH"))
                {
                    PatchJSON(data[1]);
                }
                else
                {
                    DeleteJSON(data[1]);
                }

            }
        }

        //Deserialize object in JSON format to a CS object format
        public static void InsertJSON(string personJSON)
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(personJSON);
            InsertData(person);
        }

        public static void PatchJSON(string personJSON)
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(personJSON);
            EditData(person);
        }

        public static void DeleteJSON(string personJSON)
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(personJSON);
            DeleteData(person);
        }

        //Inserts a person to tree
        public static void InsertData(Person person)
        {
            Node<Person> NewNodeDPI = new Node<Person>(person);

            if (!Data.Instance.DPITree.Contains(Data.Instance.DPITree.Root, NewNodeDPI))
            {
                Data.Instance.DPITree.Root = Data.Instance.DPITree.Insert(Data.Instance.DPITree.Root, NewNodeDPI);

            }
            else
            {
                MessageBox.Show("Una persona ingresada tiene el mismo DPI que otra persona. Por favor, corrige el error.");
            }
        }

        //Edits a person's info in the tree
        public static void EditData(Person person)
        {
            //Creates a new node to search in the DPI tree, using DPI as the ID.
            Person auxPerson = new Person
            {
                name = person.name,
                dpi = person.dpi,
                datebirth = person.datebirth,
                address = person.address
            };

            Node<Person> PatchNodeDPI = new Node<Person>(auxPerson);

            Data.Instance.DPITree.EditData(Data.Instance.DPITree.Root, PatchNodeDPI);

        }

        //Deletes a person in the tree
        public static void DeleteData(Person person)
        {
            Person auxPerson = new Person
            {
                name = person.name,
                dpi = person.dpi,
            };
            Node<Person> DeleteNodeDPI = new Node<Person>(auxPerson);

            Data.Instance.DPITree.Delete(Data.Instance.DPITree.Root, DeleteNodeDPI);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchname = tBName.Text;

            //Create a new object with the name
            Person sperson = new Person
            {
                name = searchname
            };

            Node<Person> node = new Node<Person>(sperson);

            Data.Instance.DPITree.SearchInOrder(Data.Instance.DPITree.Root, node);
            rTBSearch.Text = ExportData();
        }

        public static string ExportData()
        {
            string jsonInfo = "";
            foreach (var item in Data.Instance.DPITree.NodeList)
            {
                var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                jsonInfo += jsonString;
            }

            File.Delete("SearchResults.json");
            System.IO.File.WriteAllText("SearchResults.json", jsonInfo);

            MessageBox.Show("Se ha creado un nuevo archivo json para la búsqueda.");
            return jsonInfo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mTBBuscarDPI.Text.Length == 13)
            {
                //Create new person object
                Person person = new Person
                {
                    dpi = Convert.ToInt64(mTBBuscarDPI.Text)
                };
                Node<Person> auxPerson = new Node<Person>(person);

                //Search person
                Node<Person> Person = Data.Instance.DPITree.Search(Data.Instance.DPITree.Root, auxPerson);
                if (Person.Record != auxPerson.Record)
                {
                    MessageBox.Show("Búsqueda exitosa.");

                    //Exportar txt con los datos de persona
                    string data = "Name: " + Person.Record.name + "\nDateBirth: " + Convert.ToString(Person.Record.datebirth) + "\n Companies: ";
                    foreach (string company in Person.Record.companies)
                    {
                        data += "\n   " + company;
                    }

                    System.IO.File.WriteAllText("Person_Data.txt", data);
                    rTBDPISearch.Text = data;


                }
                else
                {
                  //  MessageBox.Show("No existe registro de la persona en la estrucutra de datos.");
                }
                int i = 0;
                foreach (var item in convDpI)
                {
                    if (item.Equals(mTBBuscarDPI.Text))
                    {
                        rTBDPISearch.Text += conversations[i];
                    }
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Ingresa un DPI válido.");
            }
        }

        private void mTBBuscarDPI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComprimirCartas_Click(object sender, EventArgs e)
        {
            List<string> Letters = new List<string>();
            Queue<string> dpi = new Queue<string>();

            foreach (string file in Directory.EnumerateFiles("letters-input", "*.txt"))
            {
                Letters.Add(File.ReadAllText(file)); //Add content of letter to list

                Regex expression = new Regex(@"(?<=REC-)\d+");      //Get # DPI
                var result = expression.Match(file);
                dpi.Enqueue(Convert.ToString(result));          //Add DPI to list
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
                System.IO.File.WriteAllText(FileName, encode.Compress(text));   //Create file
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

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                long DPI = Convert.ToInt64(mTBDecompDPI.Text);
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

                    string directoryName = "decompressed-inputs/decompressed-REC-" + Convert.ToString(DPI);
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
                        string FileName = directoryName + "/" + "decompressed-REC-" + Convert.ToString(DPI) + "-" + Convert.ToString(i) + ".txt";
                        System.IO.File.WriteAllText(FileName, lzw.Decompress(codes));   //Create file;
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

        private void btnEncriptarConv_Click(object sender, EventArgs e)
        {
            if (tBKeyEncrypt.Text.Length > 2 && tBKeyEncrypt.Text.Length < 7)
            {
                String key = tBKeyEncrypt.Text;
                List<string> Letters = new List<string>();
                Queue<string> dpi = new Queue<string>();

                foreach (string file in Directory.EnumerateFiles("conv-input", "*.txt"))
                {
                    Letters.Add(File.ReadAllText(file)); //Add content of letter to list

                    Regex expression = new Regex(@"(?<=CONV-)\d+");      //Get # DPI
                    var result = expression.Match(file);
                    dpi.Enqueue(Convert.ToString(result));          //Add DPI to list
                }

                List<string> EncodedLetters = new List<string>();

                if (!Directory.Exists("encrypted-inputs"))
                {
                    Directory.CreateDirectory("encrypted-inputs");    //Create folder
                }

                int counter = 1;
                foreach (string text in Letters)
                {
                    Transposition cipher = new Transposition();     //Create a new instance for LZW
                    string xDpi = dpi.Peek();       //Take one of the DPIs on the queue
                    string FileName = @"encrypted-inputs\" + "crypted-CONV-" + xDpi + "-" + counter.ToString() + ".txt";
                    System.IO.File.WriteAllText(FileName, cipher.Encrypt(key, text, '|'));   //Create file
                    dpi.Dequeue();
                    convDpI.Add(xDpi);
                    conversations.Add(text);

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
                MessageBox.Show("Se han encriptado las conversaciones.");
            }
            else
            {
                MessageBox.Show("Elige una llave con longitud mayor que 2 y menor que 7.");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tBKeyDecrypt.Text.Length > 2 && tBKeyDecrypt.Text.Length < 7)
            {
                try
                {
                    long DPI = Convert.ToInt64(mTBDPIDecipher.Text);
                    bool verify = false;

                    List<string> FilteredFiles = new List<string>();
                    foreach (string file in Directory.EnumerateFiles("encrypted-inputs", "*.txt"))    //Iterate all files from directory
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

                        string directoryName = "decrypted-inputs/decrypted-REC-" + Convert.ToString(DPI);
                        if (!Directory.Exists("decrypted-inputs"))
                        {
                            Directory.CreateDirectory("decrypted-inputs");    //Create folder          
                        }
                        if (!Directory.Exists(directoryName))
                        {
                            Directory.CreateDirectory(directoryName);    //Create folder
                        }

                        int i = 1;

                        foreach (string decipher in FilteredFiles)
                        {

                            Transposition dcphr = new Transposition();        //Create new LZW instance
                            string FileName = directoryName + "/" + "decrypted-REC-" + Convert.ToString(DPI) + "-" + Convert.ToString(i) + ".txt";
                            System.IO.File.WriteAllText(FileName, dcphr.Decrypt(tBKeyDecrypt.Text, decipher));   //Create file;
                            scodes.Clear();
                            codes.Clear();
                            i++;
                        }

                        MessageBox.Show("Se han descifrado las conversaciones para el DPI: " + DPI.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se han encontrado conversaciones para el DPI ingresado.");
                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR: Ha ocurrido un problema con la descompresión. Por favor, reinicia el sistema.");
                }
            }
            else
            {
                MessageBox.Show("Elige una llave con longitud mayor que 2 y menor que 7.");
            }
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(mTBP.Text);
            int q = Convert.ToInt32(mTBQ.Text);
            char sep = ',';

            RSA rsa = new RSA();
            String key = rsa.generateKeys(p, q);
            String[] keyPos = key.Split(sep); //n,e,d

            tBPublicKey.Text = keyPos[0] + "," + keyPos[1];
            tBPrivateKey.Text = keyPos[0] + "," + keyPos[2];


        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String[] publicKey = tBPublicKey.Text.Split(',');
            int n = Convert.ToInt32(publicKey[0]);
            int ex = Convert.ToInt32(publicKey[1]);

            string message = tBMessage.Text;

            long mesASCII = long.Parse(message);
            RSA rsa = new RSA();
            long c = rsa.encryptMessage(mesASCII, n, ex);
            mTBC.Text = Convert.ToString(c);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(mTBC2.Text);
            string mx = tBMessage.Text;
            String[] privateKey = tBPublicKey.Text.Split(',');
            int n = Convert.ToInt32(privateKey[0]);
            int d = Convert.ToInt32(privateKey[1]);

            RSA rsa = new RSA();
            long m = rsa.decryptMessage(c, n, d);
            tBMessageDecrypted.Text = Convert.ToString(m);

            
        }

        private void btnCOD_Click(object sender, EventArgs e)
        {

        }
    }
}
