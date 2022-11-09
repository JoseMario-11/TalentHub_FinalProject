using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalentHub_Project.Helpers
{
    public class FileOperations
    {
        public static List<string> getFiles()
        {
            List<string> files = null;

            using (var FBD = new FolderBrowserDialog())
            {
                DialogResult result = FBD.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FBD.SelectedPath))
                {
                    var filesArray = Directory.GetFiles(FBD.SelectedPath);
                    files = new List<string>(filesArray);
                }
            }
            return files;
        }


        // Regex[0] = validación de formato de archivo
        // Regex[1] = validación del prefijo del formato del nombre del archivo
        // Regex[2] = Validación del sufijo del formato del nombre del archivo
        // Regex[3] = expresión regular para obtener el número que identifica el archivo
        // Regex[4] = validación y obtención del formato dpi del nombre del archivo
        // RETURN: string[0] = dpi del archivo, string[1] = numero de identificación del archivo
        public static string[] getData(string filePath, Regex[] regularExpressions)
        {
            string[] data = null;
            if (regularExpressions[0].IsMatch(filePath))
            {
                string fileName = regularExpressions[0].Match(filePath).Value;
                if (regularExpressions[1].IsMatch(fileName) && regularExpressions[2].IsMatch(fileName))
                {
                    string firstData = fileName;
                    firstData = regularExpressions[1].Replace(firstData, string.Empty);
                    string secondData = regularExpressions[3].Match(firstData).Value;
                    firstData = regularExpressions[2].Replace(firstData, string.Empty);
                    if (regularExpressions[4].IsMatch(firstData))
                    {
                        data = new string[2];
                        data[0] = firstData;
                        data[1] = secondData;
                    }
                }
            }
            return data;
        }
    }
}
