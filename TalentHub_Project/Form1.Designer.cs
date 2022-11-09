
namespace TalentHub_Project
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPUploadRecords = new System.Windows.Forms.TabPage();
            this.lUploadRecords = new System.Windows.Forms.Label();
            this.bUploadRecords = new System.Windows.Forms.Button();
            this.tPUploadLetters = new System.Windows.Forms.TabPage();
            this.bUploadLetters = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tPSearchName = new System.Windows.Forms.TabPage();
            this.tBSearchName = new System.Windows.Forms.TextBox();
            this.bSearchName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tPSearchDPI = new System.Windows.Forms.TabPage();
            this.mTBSearchDPI = new System.Windows.Forms.MaskedTextBox();
            this.nSearchDPI = new System.Windows.Forms.Button();
            this.lSearchDPI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tPSearchLetters = new System.Windows.Forms.TabPage();
            this.bSearchLetter = new System.Windows.Forms.Button();
            this.mTBSearchLetters = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tPConversaciones = new System.Windows.Forms.TabPage();
            this.bConversationsDPI = new System.Windows.Forms.Button();
            this.mTBConversationsDPI = new System.Windows.Forms.MaskedTextBox();
            this.lAttribute = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.tPAutentication = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tPUploadRecords.SuspendLayout();
            this.tPUploadLetters.SuspendLayout();
            this.tPSearchName.SuspendLayout();
            this.tPSearchDPI.SuspendLayout();
            this.tPSearchLetters.SuspendLayout();
            this.tPConversaciones.SuspendLayout();
            this.tPAutentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPUploadRecords);
            this.tabControl1.Controls.Add(this.tPUploadLetters);
            this.tabControl1.Controls.Add(this.tPSearchName);
            this.tabControl1.Controls.Add(this.tPSearchDPI);
            this.tabControl1.Controls.Add(this.tPSearchLetters);
            this.tabControl1.Controls.Add(this.tPConversaciones);
            this.tabControl1.Controls.Add(this.tPAutentication);
            this.tabControl1.Location = new System.Drawing.Point(21, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tPUploadRecords
            // 
            this.tPUploadRecords.Controls.Add(this.lUploadRecords);
            this.tPUploadRecords.Controls.Add(this.bUploadRecords);
            this.tPUploadRecords.Location = new System.Drawing.Point(4, 22);
            this.tPUploadRecords.Name = "tPUploadRecords";
            this.tPUploadRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tPUploadRecords.Size = new System.Drawing.Size(429, 187);
            this.tPUploadRecords.TabIndex = 1;
            this.tPUploadRecords.Text = "Cargar registros";
            this.tPUploadRecords.UseVisualStyleBackColor = true;
            // 
            // lUploadRecords
            // 
            this.lUploadRecords.Location = new System.Drawing.Point(60, 30);
            this.lUploadRecords.Name = "lUploadRecords";
            this.lUploadRecords.Size = new System.Drawing.Size(285, 55);
            this.lUploadRecords.TabIndex = 1;
            this.lUploadRecords.Text = "Cargue múltiples registros por medio de un archivo con el formato sugerido:\r\n[Nom" +
    "bre,DPI,FechaNacimento,Dirección,Compañías[]]";
            this.lUploadRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bUploadRecords
            // 
            this.bUploadRecords.Location = new System.Drawing.Point(148, 115);
            this.bUploadRecords.Name = "bUploadRecords";
            this.bUploadRecords.Size = new System.Drawing.Size(98, 23);
            this.bUploadRecords.TabIndex = 0;
            this.bUploadRecords.Text = "Cargar registros";
            this.bUploadRecords.UseVisualStyleBackColor = true;
            this.bUploadRecords.Click += new System.EventHandler(this.bUploadRecords_Click);
            // 
            // tPUploadLetters
            // 
            this.tPUploadLetters.Controls.Add(this.bUploadLetters);
            this.tPUploadLetters.Controls.Add(this.label5);
            this.tPUploadLetters.Location = new System.Drawing.Point(4, 22);
            this.tPUploadLetters.Name = "tPUploadLetters";
            this.tPUploadLetters.Size = new System.Drawing.Size(429, 187);
            this.tPUploadLetters.TabIndex = 5;
            this.tPUploadLetters.Text = "Cargar cartas";
            this.tPUploadLetters.UseVisualStyleBackColor = true;
            // 
            // bUploadLetters
            // 
            this.bUploadLetters.Location = new System.Drawing.Point(147, 107);
            this.bUploadLetters.Name = "bUploadLetters";
            this.bUploadLetters.Size = new System.Drawing.Size(97, 23);
            this.bUploadLetters.TabIndex = 1;
            this.bUploadLetters.Text = "Cargar cartas";
            this.bUploadLetters.UseVisualStyleBackColor = true;
            this.bUploadLetters.Click += new System.EventHandler(this.bUploadLetters_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Se cargarán todas las cartas en archivos txt de en la caperta indicada que la  co" +
    "ntiene";
            // 
            // tPSearchName
            // 
            this.tPSearchName.Controls.Add(this.tBSearchName);
            this.tPSearchName.Controls.Add(this.bSearchName);
            this.tPSearchName.Controls.Add(this.label2);
            this.tPSearchName.Controls.Add(this.label1);
            this.tPSearchName.Location = new System.Drawing.Point(4, 22);
            this.tPSearchName.Name = "tPSearchName";
            this.tPSearchName.Size = new System.Drawing.Size(429, 187);
            this.tPSearchName.TabIndex = 2;
            this.tPSearchName.Text = "Buscar [Nombre]";
            this.tPSearchName.UseVisualStyleBackColor = true;
            // 
            // tBSearchName
            // 
            this.tBSearchName.Location = new System.Drawing.Point(160, 84);
            this.tBSearchName.Name = "tBSearchName";
            this.tBSearchName.Size = new System.Drawing.Size(172, 20);
            this.tBSearchName.TabIndex = 3;
            // 
            // bSearchName
            // 
            this.bSearchName.Location = new System.Drawing.Point(174, 122);
            this.bSearchName.Name = "bSearchName";
            this.bSearchName.Size = new System.Drawing.Size(75, 23);
            this.bSearchName.TabIndex = 2;
            this.bSearchName.Text = "Buscar";
            this.bSearchName.UseVisualStyleBackColor = true;
            this.bSearchName.Click += new System.EventHandler(this.bSearchName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genera un archivo con todos los registros que conincidan con ese nombre.\r\n";
            // 
            // tPSearchDPI
            // 
            this.tPSearchDPI.Controls.Add(this.mTBSearchDPI);
            this.tPSearchDPI.Controls.Add(this.nSearchDPI);
            this.tPSearchDPI.Controls.Add(this.lSearchDPI);
            this.tPSearchDPI.Controls.Add(this.label3);
            this.tPSearchDPI.Location = new System.Drawing.Point(4, 22);
            this.tPSearchDPI.Name = "tPSearchDPI";
            this.tPSearchDPI.Size = new System.Drawing.Size(429, 187);
            this.tPSearchDPI.TabIndex = 3;
            this.tPSearchDPI.Text = "Buscar [DPI]";
            this.tPSearchDPI.UseVisualStyleBackColor = true;
            // 
            // mTBSearchDPI
            // 
            this.mTBSearchDPI.Location = new System.Drawing.Point(186, 100);
            this.mTBSearchDPI.Mask = "9999999999999";
            this.mTBSearchDPI.Name = "mTBSearchDPI";
            this.mTBSearchDPI.Size = new System.Drawing.Size(86, 20);
            this.mTBSearchDPI.TabIndex = 4;
            this.mTBSearchDPI.ValidatingType = typeof(int);
            // 
            // nSearchDPI
            // 
            this.nSearchDPI.Location = new System.Drawing.Point(172, 138);
            this.nSearchDPI.Name = "nSearchDPI";
            this.nSearchDPI.Size = new System.Drawing.Size(75, 23);
            this.nSearchDPI.TabIndex = 3;
            this.nSearchDPI.Text = "Buscar";
            this.nSearchDPI.UseVisualStyleBackColor = true;
            this.nSearchDPI.Click += new System.EventHandler(this.nSearchDPI_Click);
            // 
            // lSearchDPI
            // 
            this.lSearchDPI.AutoSize = true;
            this.lSearchDPI.Location = new System.Drawing.Point(152, 103);
            this.lSearchDPI.Name = "lSearchDPI";
            this.lSearchDPI.Size = new System.Drawing.Size(28, 13);
            this.lSearchDPI.TabIndex = 2;
            this.lSearchDPI.Text = "DPI:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Devuelve todas las codificaciones del DPI que se brindan a las empresas en las qu" +
    "e ha iniciado un proceso de reclutamiento identificado con el DPI brindado.";
            // 
            // tPSearchLetters
            // 
            this.tPSearchLetters.Controls.Add(this.bSearchLetter);
            this.tPSearchLetters.Controls.Add(this.mTBSearchLetters);
            this.tPSearchLetters.Controls.Add(this.label4);
            this.tPSearchLetters.Controls.Add(this.label6);
            this.tPSearchLetters.Location = new System.Drawing.Point(4, 22);
            this.tPSearchLetters.Name = "tPSearchLetters";
            this.tPSearchLetters.Size = new System.Drawing.Size(429, 187);
            this.tPSearchLetters.TabIndex = 4;
            this.tPSearchLetters.Text = "Buscar [Cartas]";
            this.tPSearchLetters.UseVisualStyleBackColor = true;
            // 
            // bSearchLetter
            // 
            this.bSearchLetter.Location = new System.Drawing.Point(236, 105);
            this.bSearchLetter.Name = "bSearchLetter";
            this.bSearchLetter.Size = new System.Drawing.Size(75, 23);
            this.bSearchLetter.TabIndex = 13;
            this.bSearchLetter.Text = "Buscar";
            this.bSearchLetter.UseVisualStyleBackColor = true;
            this.bSearchLetter.Click += new System.EventHandler(this.bSearchLetter_Click);
            // 
            // mTBSearchLetters
            // 
            this.mTBSearchLetters.Location = new System.Drawing.Point(144, 107);
            this.mTBSearchLetters.Mask = "9999999999999";
            this.mTBSearchLetters.Name = "mTBSearchLetters";
            this.mTBSearchLetters.Size = new System.Drawing.Size(86, 20);
            this.mTBSearchLetters.TabIndex = 12;
            this.mTBSearchLetters.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DPI:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(43, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 39);
            this.label6.TabIndex = 4;
            this.label6.Text = "Devuelve todas las cartas codificadas y la posibilidad de decodificación del recl" +
    "uta identificado con el DPI brindado.\r\n";
            // 
            // tPConversaciones
            // 
            this.tPConversaciones.Controls.Add(this.bConversationsDPI);
            this.tPConversaciones.Controls.Add(this.mTBConversationsDPI);
            this.tPConversaciones.Controls.Add(this.lAttribute);
            this.tPConversaciones.Controls.Add(this.lDescription);
            this.tPConversaciones.Location = new System.Drawing.Point(4, 22);
            this.tPConversaciones.Name = "tPConversaciones";
            this.tPConversaciones.Size = new System.Drawing.Size(429, 187);
            this.tPConversaciones.TabIndex = 6;
            this.tPConversaciones.Text = "Conversaciones";
            this.tPConversaciones.UseVisualStyleBackColor = true;
            // 
            // bConversationsDPI
            // 
            this.bConversationsDPI.Location = new System.Drawing.Point(232, 118);
            this.bConversationsDPI.Name = "bConversationsDPI";
            this.bConversationsDPI.Size = new System.Drawing.Size(75, 23);
            this.bConversationsDPI.TabIndex = 17;
            this.bConversationsDPI.Text = "Buscar";
            this.bConversationsDPI.UseVisualStyleBackColor = true;
            this.bConversationsDPI.Click += new System.EventHandler(this.bConversationsDPI_Click);
            // 
            // mTBConversationsDPI
            // 
            this.mTBConversationsDPI.Location = new System.Drawing.Point(140, 120);
            this.mTBConversationsDPI.Mask = "9999999999999";
            this.mTBConversationsDPI.Name = "mTBConversationsDPI";
            this.mTBConversationsDPI.Size = new System.Drawing.Size(86, 20);
            this.mTBConversationsDPI.TabIndex = 16;
            this.mTBConversationsDPI.ValidatingType = typeof(int);
            // 
            // lAttribute
            // 
            this.lAttribute.AutoSize = true;
            this.lAttribute.Location = new System.Drawing.Point(106, 123);
            this.lAttribute.Name = "lAttribute";
            this.lAttribute.Size = new System.Drawing.Size(28, 13);
            this.lAttribute.TabIndex = 15;
            this.lAttribute.Text = "DPI:";
            // 
            // lDescription
            // 
            this.lDescription.Location = new System.Drawing.Point(39, 45);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(350, 39);
            this.lDescription.TabIndex = 14;
            this.lDescription.Text = "Devuelve todas las cartas codificadas y la posibilidad de decodificación del recl" +
    "uta identificado con el DPI brindado.\r\n";
            // 
            // tPAutentication
            // 
            this.tPAutentication.Controls.Add(this.button1);
            this.tPAutentication.Location = new System.Drawing.Point(4, 22);
            this.tPAutentication.Name = "tPAutentication";
            this.tPAutentication.Size = new System.Drawing.Size(429, 187);
            this.tPAutentication.TabIndex = 7;
            this.tPAutentication.Text = "Autenticación";
            this.tPAutentication.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Autenticación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPUploadRecords.ResumeLayout(false);
            this.tPUploadLetters.ResumeLayout(false);
            this.tPSearchName.ResumeLayout(false);
            this.tPSearchName.PerformLayout();
            this.tPSearchDPI.ResumeLayout(false);
            this.tPSearchDPI.PerformLayout();
            this.tPSearchLetters.ResumeLayout(false);
            this.tPSearchLetters.PerformLayout();
            this.tPConversaciones.ResumeLayout(false);
            this.tPConversaciones.PerformLayout();
            this.tPAutentication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPUploadRecords;
        private System.Windows.Forms.Label lUploadRecords;
        private System.Windows.Forms.Button bUploadRecords;
        private System.Windows.Forms.TabPage tPSearchName;
        private System.Windows.Forms.TabPage tPSearchDPI;
        private System.Windows.Forms.TextBox tBSearchName;
        private System.Windows.Forms.Button bSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nSearchDPI;
        private System.Windows.Forms.Label lSearchDPI;
        private System.Windows.Forms.MaskedTextBox mTBSearchDPI;
        private System.Windows.Forms.TabPage tPUploadLetters;
        private System.Windows.Forms.Button bUploadLetters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tPSearchLetters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bSearchLetter;
        private System.Windows.Forms.MaskedTextBox mTBSearchLetters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tPConversaciones;
        private System.Windows.Forms.Button bConversationsDPI;
        private System.Windows.Forms.MaskedTextBox mTBConversationsDPI;
        private System.Windows.Forms.Label lAttribute;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TabPage tPAutentication;
        private System.Windows.Forms.Button button1;
    }
}

