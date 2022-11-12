
namespace TalentHub
{
    partial class Form1
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
            this.tCMenu = new System.Windows.Forms.TabControl();
            this.tPDataEntry = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tPImportFiles = new System.Windows.Forms.TabPage();
            this.bImportFiles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bImportLetters = new System.Windows.Forms.Button();
            this.bImportConv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mTBSearchDPI = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tCMenu.SuspendLayout();
            this.tPDataEntry.SuspendLayout();
            this.tPImportFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMenu
            // 
            this.tCMenu.Controls.Add(this.tPDataEntry);
            this.tCMenu.Controls.Add(this.tPImportFiles);
            this.tCMenu.Location = new System.Drawing.Point(8, 9);
            this.tCMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tCMenu.Name = "tCMenu";
            this.tCMenu.SelectedIndex = 0;
            this.tCMenu.Size = new System.Drawing.Size(645, 362);
            this.tCMenu.TabIndex = 0;
            // 
            // tPDataEntry
            // 
            this.tPDataEntry.Controls.Add(this.textBox1);
            this.tPDataEntry.Controls.Add(this.label2);
            this.tPDataEntry.Controls.Add(this.button1);
            this.tPDataEntry.Location = new System.Drawing.Point(4, 22);
            this.tPDataEntry.Margin = new System.Windows.Forms.Padding(2);
            this.tPDataEntry.Name = "tPDataEntry";
            this.tPDataEntry.Padding = new System.Windows.Forms.Padding(2);
            this.tPDataEntry.Size = new System.Drawing.Size(637, 336);
            this.tPDataEntry.TabIndex = 0;
            this.tPDataEntry.Text = "Data entry";
            this.tPDataEntry.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input file (CSV)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPImportFiles
            // 
            this.tPImportFiles.Controls.Add(this.label7);
            this.tPImportFiles.Controls.Add(this.label6);
            this.tPImportFiles.Controls.Add(this.mTBSearchDPI);
            this.tPImportFiles.Controls.Add(this.label5);
            this.tPImportFiles.Controls.Add(this.bImportConv);
            this.tPImportFiles.Controls.Add(this.bImportLetters);
            this.tPImportFiles.Controls.Add(this.bImportFiles);
            this.tPImportFiles.Controls.Add(this.label4);
            this.tPImportFiles.Controls.Add(this.label3);
            this.tPImportFiles.Location = new System.Drawing.Point(4, 22);
            this.tPImportFiles.Margin = new System.Windows.Forms.Padding(2);
            this.tPImportFiles.Name = "tPImportFiles";
            this.tPImportFiles.Padding = new System.Windows.Forms.Padding(2);
            this.tPImportFiles.Size = new System.Drawing.Size(637, 336);
            this.tPImportFiles.TabIndex = 1;
            this.tPImportFiles.Text = "Cargar Archivos";
            this.tPImportFiles.UseVisualStyleBackColor = true;
            // 
            // bImportFiles
            // 
            this.bImportFiles.Location = new System.Drawing.Point(270, 91);
            this.bImportFiles.Name = "bImportFiles";
            this.bImportFiles.Size = new System.Drawing.Size(97, 21);
            this.bImportFiles.TabIndex = 2;
            this.bImportFiles.Text = "Importar";
            this.bImportFiles.UseVisualStyleBackColor = true;
            this.bImportFiles.Click += new System.EventHandler(this.bImportFiles_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cartas de recomendacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conversaciones:";
            // 
            // bImportLetters
            // 
            this.bImportLetters.Location = new System.Drawing.Point(217, 240);
            this.bImportLetters.Name = "bImportLetters";
            this.bImportLetters.Size = new System.Drawing.Size(75, 23);
            this.bImportLetters.TabIndex = 3;
            this.bImportLetters.Text = "Importar";
            this.bImportLetters.UseVisualStyleBackColor = true;
            // 
            // bImportConv
            // 
            this.bImportConv.Location = new System.Drawing.Point(422, 240);
            this.bImportConv.Name = "bImportConv";
            this.bImportConv.Size = new System.Drawing.Size(75, 23);
            this.bImportConv.TabIndex = 4;
            this.bImportConv.Text = "Importar";
            this.bImportConv.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Importar archivos de un recluta";
            // 
            // mTBSearchDPI
            // 
            this.mTBSearchDPI.Location = new System.Drawing.Point(276, 197);
            this.mTBSearchDPI.Mask = "9999999999999";
            this.mTBSearchDPI.Name = "mTBSearchDPI";
            this.mTBSearchDPI.Size = new System.Drawing.Size(89, 20);
            this.mTBSearchDPI.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(125, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(389, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Opción para cargar múltiples archivos de cartas de recomendación y conversaciones" +
    " para más de un recluta.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DPI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 380);
            this.Controls.Add(this.tCMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tCMenu.ResumeLayout(false);
            this.tPDataEntry.ResumeLayout(false);
            this.tPDataEntry.PerformLayout();
            this.tPImportFiles.ResumeLayout(false);
            this.tPImportFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tCMenu;
        private System.Windows.Forms.TabPage tPDataEntry;
        private System.Windows.Forms.TabPage tPImportFiles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bImportFiles;
        private System.Windows.Forms.MaskedTextBox mTBSearchDPI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bImportConv;
        private System.Windows.Forms.Button bImportLetters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

