using ClassLibrary.DES;
using ClassLibrary.POO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TalentHub_Project.Helpers;

namespace TalentHub_Project
{
    public partial class CryptedConversations : Form
    {
        private Recruit _Recruit;
        private Dictionary<int, string> Conversations = new Dictionary<int, string>();
        public CryptedConversations(Recruit recruit)
        {
            _Recruit = recruit;
            getConversations();
            InitializeComponent();
        }

        private void CryptedConversations_Load(object sender, EventArgs e)
        {
            string recruitInformation = 
                $"Nombre: {_Recruit.name}\n" +
                $"DPI: {_Recruit.dpi}\n" +
                $"Dirección: {_Recruit.address}";
            rTBRecruitInformation.Text = recruitInformation;

            string chatInformation;
            if (Conversations.Count != 0)
            {
                if (Conversations.Count == 1)
                {
                    chatInformation = "Se ha almacenado una conversación con el recluta.";
                }
                else
                {
                    chatInformation = String.Format("Se han almacenado {0} conversaciones con el recluta.", Conversations.Count.ToString());
                }
            }
            else
            {
                bShowConversations.Dispose();
                tBPassword.Dispose();
                chatInformation = "El recluta no cuenta con ninguna conversación almacenada.";
            }
            rTBConversationsInformation.Text = chatInformation;
        }

        private void getConversations()
        {
            List<string> files = FileOperations.getFiles();
            foreach (string filePath in files)
            {
                Regex[] regularExpressions = { new Regex(@"CONV-\d+.-\d+"), new Regex(@"^CONV-"), new Regex(@"-\d+$"), new Regex(@"\d+$"), new Regex(@"\d{13}") };

                string[] data = FileOperations.getData(filePath, regularExpressions);

                if (data != null && data[0] == _Recruit.dpi)
                {
                    string chat = File.ReadAllText(filePath);
                    Conversations.Add(Convert.ToInt32(data[1]), DES.encrypt(chat,Data.Instance.key));
                }
            }
        }

        private void bShowConversations_Click(object sender, EventArgs e)
        {
            try
            {
                string password = tBPassword.Text;
                if (password == Data.Instance.key)
                {
                    rTBConversations.Text = "";
                    string decryptConversations = "";

                    foreach (var conversation in Conversations)
                    {
                        decryptConversations += String.Format("Conversación {0}\n\n" +
                            "{1}\n\n\n", conversation.Key, DES.decrypt(conversation.Value, password));
                    }
                    rTBConversations.Text = decryptConversations.Trim();
                    tBPassword.Dispose();
                    bShowConversations.Dispose();
                }
                else
                {
                    tBPassword.Text = "";
                    MessageBox.Show("Contraseña incorrecta", "Error en la contraseña.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido algún error inesperado.", "Error");
            }
        }
    }
}
