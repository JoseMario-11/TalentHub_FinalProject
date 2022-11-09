
namespace TalentHub_Project
{
    partial class CodingDPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTBRecruitInformation = new System.Windows.Forms.RichTextBox();
            this.bSearchCompanies = new System.Windows.Forms.Button();
            this.tBCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTBDPICode = new System.Windows.Forms.RichTextBox();
            this.rTBDPIDecode = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lDPIDecode = new System.Windows.Forms.Label();
            this.bDecodeDPI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTBRecruitInformation
            // 
            this.rTBRecruitInformation.BackColor = System.Drawing.Color.White;
            this.rTBRecruitInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBRecruitInformation.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBRecruitInformation.Location = new System.Drawing.Point(158, 70);
            this.rTBRecruitInformation.Name = "rTBRecruitInformation";
            this.rTBRecruitInformation.ReadOnly = true;
            this.rTBRecruitInformation.Size = new System.Drawing.Size(462, 88);
            this.rTBRecruitInformation.TabIndex = 0;
            this.rTBRecruitInformation.Text = "";
            // 
            // bSearchCompanies
            // 
            this.bSearchCompanies.Location = new System.Drawing.Point(450, 201);
            this.bSearchCompanies.Name = "bSearchCompanies";
            this.bSearchCompanies.Size = new System.Drawing.Size(75, 23);
            this.bSearchCompanies.TabIndex = 1;
            this.bSearchCompanies.Text = "Buscar";
            this.bSearchCompanies.UseVisualStyleBackColor = true;
            this.bSearchCompanies.Click += new System.EventHandler(this.bSearchCompanies_Click);
            // 
            // tBCompany
            // 
            this.tBCompany.Location = new System.Drawing.Point(232, 203);
            this.tBCompany.Name = "tBCompany";
            this.tBCompany.Size = new System.Drawing.Size(212, 20);
            this.tBCompany.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Búsqueda del DPI del recluta codificado basado en la empresa que lo solicita. Tam" +
    "bién, la posibilidad de decodificar dicho dpi.";
            // 
            // rTBDPICode
            // 
            this.rTBDPICode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBDPICode.Location = new System.Drawing.Point(84, 265);
            this.rTBDPICode.Name = "rTBDPICode";
            this.rTBDPICode.ReadOnly = true;
            this.rTBDPICode.Size = new System.Drawing.Size(610, 62);
            this.rTBDPICode.TabIndex = 4;
            this.rTBDPICode.Text = "";
            // 
            // rTBDPIDecode
            // 
            this.rTBDPIDecode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBDPIDecode.Location = new System.Drawing.Point(260, 412);
            this.rTBDPIDecode.Name = "rTBDPIDecode";
            this.rTBDPIDecode.ReadOnly = true;
            this.rTBDPIDecode.Size = new System.Drawing.Size(246, 28);
            this.rTBDPIDecode.TabIndex = 5;
            this.rTBDPIDecode.Text = "";
            this.rTBDPIDecode.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "DPI Codificado:";
            // 
            // lDPIDecode
            // 
            this.lDPIDecode.AutoSize = true;
            this.lDPIDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDPIDecode.Location = new System.Drawing.Point(84, 385);
            this.lDPIDecode.Name = "lDPIDecode";
            this.lDPIDecode.Size = new System.Drawing.Size(192, 24);
            this.lDPIDecode.TabIndex = 7;
            this.lDPIDecode.Text = "Decodificación DPI:";
            this.lDPIDecode.Visible = false;
            // 
            // bDecodeDPI
            // 
            this.bDecodeDPI.Location = new System.Drawing.Point(329, 353);
            this.bDecodeDPI.Name = "bDecodeDPI";
            this.bDecodeDPI.Size = new System.Drawing.Size(115, 25);
            this.bDecodeDPI.TabIndex = 8;
            this.bDecodeDPI.Text = "Mostrar DPI";
            this.bDecodeDPI.UseVisualStyleBackColor = true;
            this.bDecodeDPI.Click += new System.EventHandler(this.bDecodeDPI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Paradise", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "DPI Codificados";
            // 
            // CodingDPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(782, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bDecodeDPI);
            this.Controls.Add(this.lDPIDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rTBDPIDecode);
            this.Controls.Add(this.rTBDPICode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBCompany);
            this.Controls.Add(this.bSearchCompanies);
            this.Controls.Add(this.rTBRecruitInformation);
            this.Name = "CodingDPI";
            this.Text = "CodingDPI";
            this.Load += new System.EventHandler(this.CodingDPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBRecruitInformation;
        private System.Windows.Forms.Button bSearchCompanies;
        private System.Windows.Forms.TextBox tBCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTBDPICode;
        private System.Windows.Forms.RichTextBox rTBDPIDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDPIDecode;
        private System.Windows.Forms.Button bDecodeDPI;
        private System.Windows.Forms.Label label3;
    }
}