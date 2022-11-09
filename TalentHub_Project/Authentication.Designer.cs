
namespace TalentHub_Project
{
    partial class Authentication
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
            this.lTitle = new System.Windows.Forms.Label();
            this.mTBPassword = new System.Windows.Forms.MaskedTextBox();
            this.tBRecluiter = new System.Windows.Forms.TextBox();
            this.lCompanies = new System.Windows.Forms.Label();
            this.lRecluiter = new System.Windows.Forms.Label();
            this.lMensaje = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.bAuthentication = new System.Windows.Forms.Button();
            this.lCipher = new System.Windows.Forms.Label();
            this.tBCompanie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(108, 38);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(312, 61);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Autenticación";
            // 
            // mTBPassword
            // 
            this.mTBPassword.Location = new System.Drawing.Point(229, 147);
            this.mTBPassword.Name = "mTBPassword";
            this.mTBPassword.PasswordChar = '*';
            this.mTBPassword.Size = new System.Drawing.Size(127, 20);
            this.mTBPassword.TabIndex = 2;
            // 
            // tBRecluiter
            // 
            this.tBRecluiter.Location = new System.Drawing.Point(45, 192);
            this.tBRecluiter.Name = "tBRecluiter";
            this.tBRecluiter.Size = new System.Drawing.Size(121, 20);
            this.tBRecluiter.TabIndex = 4;
            // 
            // lCompanies
            // 
            this.lCompanies.AutoSize = true;
            this.lCompanies.Location = new System.Drawing.Point(45, 131);
            this.lCompanies.Name = "lCompanies";
            this.lCompanies.Size = new System.Drawing.Size(59, 13);
            this.lCompanies.TabIndex = 5;
            this.lCompanies.Text = "Companies";
            // 
            // lRecluiter
            // 
            this.lRecluiter.AutoSize = true;
            this.lRecluiter.Location = new System.Drawing.Point(45, 173);
            this.lRecluiter.Name = "lRecluiter";
            this.lRecluiter.Size = new System.Drawing.Size(59, 13);
            this.lRecluiter.TabIndex = 6;
            this.lRecluiter.Text = "Reclutador";
            // 
            // lMensaje
            // 
            this.lMensaje.AutoSize = true;
            this.lMensaje.Location = new System.Drawing.Point(414, 195);
            this.lMensaje.Name = "lMensaje";
            this.lMensaje.Size = new System.Drawing.Size(57, 13);
            this.lMensaje.TabIndex = 7;
            this.lMensaje.Text = "MENSAJE";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(229, 128);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(61, 13);
            this.lPassword.TabIndex = 8;
            this.lPassword.Text = "Contraseña";
            // 
            // bAuthentication
            // 
            this.bAuthentication.Location = new System.Drawing.Point(229, 190);
            this.bAuthentication.Name = "bAuthentication";
            this.bAuthentication.Size = new System.Drawing.Size(127, 23);
            this.bAuthentication.TabIndex = 9;
            this.bAuthentication.Text = "Autenticar";
            this.bAuthentication.UseVisualStyleBackColor = true;
            this.bAuthentication.Click += new System.EventHandler(this.bAuthentication_Click);
            // 
            // lCipher
            // 
            this.lCipher.AutoSize = true;
            this.lCipher.Location = new System.Drawing.Point(414, 147);
            this.lCipher.Name = "lCipher";
            this.lCipher.Size = new System.Drawing.Size(54, 13);
            this.lCipher.TabIndex = 10;
            this.lCipher.Text = "CIFRADO";
            // 
            // tBCompanie
            // 
            this.tBCompanie.Location = new System.Drawing.Point(45, 144);
            this.tBCompanie.Name = "tBCompanie";
            this.tBCompanie.Size = new System.Drawing.Size(121, 20);
            this.tBCompanie.TabIndex = 11;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(560, 276);
            this.Controls.Add(this.tBCompanie);
            this.Controls.Add(this.lCipher);
            this.Controls.Add(this.bAuthentication);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lMensaje);
            this.Controls.Add(this.lRecluiter);
            this.Controls.Add(this.lCompanies);
            this.Controls.Add(this.tBRecluiter);
            this.Controls.Add(this.mTBPassword);
            this.Controls.Add(this.lTitle);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.MaskedTextBox mTBPassword;
        private System.Windows.Forms.TextBox tBRecluiter;
        private System.Windows.Forms.Label lCompanies;
        private System.Windows.Forms.Label lRecluiter;
        private System.Windows.Forms.Label lMensaje;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Button bAuthentication;
        private System.Windows.Forms.Label lCipher;
        private System.Windows.Forms.TextBox tBCompanie;
    }
}