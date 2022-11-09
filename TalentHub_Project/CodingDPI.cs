using ClassLibrary.POO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalentHub_Project
{
    public partial class CodingDPI : Form
    {
        public Recruit RecruitResult;
        public string Company;

        public CodingDPI(Recruit recruit)
        {
            RecruitResult = recruit;
            InitializeComponent();
        }

        private void CodingDPI_Load(object sender, EventArgs e)
        {
            string text = String.Format("Nombre: {0}\n" +
                "Fecha de Nacimiento:  {1}\n" +
                "Dirección: {2}", RecruitResult.name, RecruitResult.datebirth.ToString(), RecruitResult.address);
            rTBRecruitInformation.Text = text;
        }

        private void bSearchCompanies_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBCompany.Text != "")
                {
                    Company = tBCompany.Text;
                    if (RecruitResult.Coding.ContainsKey(Company))
                    {
                        rTBDPICode.Text = "";
                        string DPICode = RecruitResult.Coding[Company].CodeMessage(RecruitResult.dpi + Company);
                        rTBDPICode.Text = DPICode;
                    }
                    else
                    {
                        rTBDPICode.Text = "";
                        tBCompany.Text = "";
                        Company = "";
                        MessageBox.Show("El recluta no ha iniciado un proceso de reclutamiento con esta empresa.", "Error");
                    }
                    rTBDPIDecode.Text = "";
                    rTBDPIDecode.Visible = false;
                    lDPIDecode.Visible = false;
                    bDecodeDPI.Text = "Mostrar DPI";
                }
                else
                {
                    MessageBox.Show("No se ha ingresado ninguna empresa.", "Notificación");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error");
            }
        }

        private void bDecodeDPI_Click(object sender, EventArgs e)
        {
            try
            {
                if (rTBDPICode.Text != "")
                {
                    if (!rTBDPIDecode.Visible)
                    {
                        string dpi = RecruitResult.Coding[Company].DecodingMessage(rTBDPICode.Text);
                        Regex regexDpi = new Regex(@"^\d{13}");
                        Match match = regexDpi.Match(dpi);
                        if (match.Success)
                        {
                            rTBDPIDecode.Text = match.Value;
                            rTBDPIDecode.Visible = true;
                            lDPIDecode.Visible = true;
                            bDecodeDPI.Text = "Ocultar DPI";
                        }
                    }
                    else
                    {
                        bDecodeDPI.Text = "Mostrar DPI";
                        rTBDPIDecode.Visible = false;
                        rTBDPIDecode.Text = "";
                        lDPIDecode.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.");
            }
        }
    }
}
