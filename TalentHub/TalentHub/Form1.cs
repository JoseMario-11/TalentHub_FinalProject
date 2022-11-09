using ClassLibrary.CODING;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHub.Helpers;

namespace TalentHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bFilesSelect_Click(object sender, EventArgs e)
        {
            List<string> files = FileOperations.getFiles();

            foreach (var filepath in files)
            {
                //Expresión regular par los archivos de las cartas de recomendación
                Regex[] LettersRE = { new Regex(@"REC-\d+.-\d+"), new Regex(@"^REC-"), new Regex(@"-\d+$"), new Regex(@"\d+$"), new Regex(@"\d{13}") };
                //Expresión regular para los archivos de las conversaciones
                Regex[] conversationsRE = { new Regex(@"CONV-\d+.-\d+"), new Regex(@"^REC-"), new Regex(@"-\d+$"), new Regex(@"\d+$"), new Regex(@"\d{13}") };

                string[] rec = FileOperations.getData(filepath, LettersRE);
                string[] conv = FileOperations.getData(filepath, conversationsRE);

                if (rec != null)
                {
                    //CODIGO PARA EL ALMACENAJE DE LAS CARTAS DE RECOMENDACIÓN EN EL RECLUTA CORRESPONDIENTE EN EL ARBOL

                    //EJEMPLO
                    //var recruit = Data.Instance.ReclutasDPI.Find(data[0]);
                    //if (recruit != null)
                    //{
                    //    string letter = File.ReadAllText(filepath);
                    //    LZ78 code = new LZ78();
                    //    recruit.LettersCoding.Add(Convert.ToInt32(data[1]), code.Encoding(letter));
                    //}
                }

                if (conv != null)
                {
                    //CÓDIGO PARA EL ALMACENAJE DE CONVERSACIONES CIFRADAS, EN CARPETA
                }
            }
        }
    }
}
