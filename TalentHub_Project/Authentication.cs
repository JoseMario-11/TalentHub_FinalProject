using ClassLibrary.CODING;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHub_Project.Helpers;

namespace TalentHub_Project
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            //List<string> companies = new List<string>();
            //foreach (var relation in Data.Instance.recluiterCompany)
            //{
            //    if (!companies.Contains(relation.Key[1]))
            //    {
            //        companies.Add(relation.Key[1]);
            //    }
            //}
            //foreach (var companie in companies)
            //{
            //    cBCompanies.Items.Add(companie);
            //}
            lMensaje.Text = "";
            lCipher.Text = "";
        }

        private void bAuthentication_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBCompanie.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una compañía para realizar la autenticación");
                }
                else
                {
                    if (tBRecluiter.Text == "")
                    {
                        MessageBox.Show("Debe indicar el reclutador que será autenticado");
                    }
                    else
                    {
                        if (mTBPassword.Text == "")
                        {
                            MessageBox.Show("Debe escribir la contraseña para realizar la autenticación");
                        }
                        else
                        {
                            string companie = tBCompanie.Text;
                            string recluiter = tBRecluiter.Text;
                            string password = mTBPassword.Text;

                            string relation = recluiter + companie;
                            if (!Data.Instance.recluiterCompany.ContainsKey(relation))
                            {
                                MessageBox.Show("El reclutador no lleva el proceso de ninduna empresa ");
                            }
                            else
                            {
                                int n = Data.Instance.recluiterCompany[relation][0];
                                int k = Data.Instance.recluiterCompany[relation][1];
                                int j = Data.Instance.recluiterCompany[relation][2];

                                char[] characters = password.ToCharArray();
                                long[] cipher = new long[characters.Length];
                                int i = 0;
                                foreach (char c in characters)
                                {
                                    cipher[i] = RSA.Cipher((int)c, k, n);
                                    i++;
                                }

                                i = 0;
                                foreach (int num in cipher)
                                {
                                    characters[i] = (char)cipher[i];
                                }

                                lCipher.Text = characters.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error inesperado, " + ex.Message);
            }
        }
    }
}
