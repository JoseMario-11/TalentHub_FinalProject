
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bImportConv = new System.Windows.Forms.Button();
            this.bImportLetters = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.rTBLetters = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWatchComp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gBCartas = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComprimirCartas = new System.Windows.Forms.Button();
            this.gBBuscar = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.mTBBuscarDPI = new System.Windows.Forms.MaskedTextBox();
            this.tCMenu.SuspendLayout();
            this.tPDataEntry.SuspendLayout();
            this.tPImportFiles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBCartas.SuspendLayout();
            this.gBBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMenu
            // 
            this.tCMenu.Controls.Add(this.tPDataEntry);
            this.tCMenu.Controls.Add(this.tPImportFiles);
            this.tCMenu.Controls.Add(this.tabPage1);
            this.tCMenu.Location = new System.Drawing.Point(8, 9);
            this.tCMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tPDataEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPDataEntry.Name = "tPDataEntry";
            this.tPDataEntry.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPDataEntry.Size = new System.Drawing.Size(637, 336);
            this.tPDataEntry.TabIndex = 0;
            this.tPDataEntry.Text = "Data entry";
            this.tPDataEntry.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input file (CSV)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPImportFiles
            // 
            this.tPImportFiles.Controls.Add(this.label6);
            this.tPImportFiles.Controls.Add(this.label5);
            this.tPImportFiles.Controls.Add(this.bImportConv);
            this.tPImportFiles.Controls.Add(this.bImportLetters);
            this.tPImportFiles.Controls.Add(this.label4);
            this.tPImportFiles.Controls.Add(this.label3);
            this.tPImportFiles.Location = new System.Drawing.Point(4, 22);
            this.tPImportFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPImportFiles.Name = "tPImportFiles";
            this.tPImportFiles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tPImportFiles.Size = new System.Drawing.Size(637, 336);
            this.tPImportFiles.TabIndex = 1;
            this.tPImportFiles.Text = "Cargar Archivos";
            this.tPImportFiles.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(141, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(389, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Opción para cargar múltiples archivos de cartas de recomendación y conversaciones" +
    " para más de un recluta.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Importar archivos de reclutas";
            // 
            // bImportConv
            // 
            this.bImportConv.Location = new System.Drawing.Point(436, 210);
            this.bImportConv.Name = "bImportConv";
            this.bImportConv.Size = new System.Drawing.Size(75, 23);
            this.bImportConv.TabIndex = 4;
            this.bImportConv.Text = "Importar";
            this.bImportConv.UseVisualStyleBackColor = true;
            this.bImportConv.Click += new System.EventHandler(this.bImportConv_Click);
            // 
            // bImportLetters
            // 
            this.bImportLetters.Location = new System.Drawing.Point(231, 210);
            this.bImportLetters.Name = "bImportLetters";
            this.bImportLetters.Size = new System.Drawing.Size(75, 23);
            this.bImportLetters.TabIndex = 3;
            this.bImportLetters.Text = "Importar";
            this.bImportLetters.UseVisualStyleBackColor = true;
            this.bImportLetters.Click += new System.EventHandler(this.bImportLetters_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cartas de recomendacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conversaciones:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.rTBLetters);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnWatchComp);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.gBCartas);
            this.tabPage1.Controls.Add(this.gBBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(637, 336);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Comprimir Cartas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Cartas de recomendación del recluta";
            // 
            // rTBLetters
            // 
            this.rTBLetters.Location = new System.Drawing.Point(387, 91);
            this.rTBLetters.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rTBLetters.Name = "rTBLetters";
            this.rTBLetters.ReadOnly = true;
            this.rTBLetters.Size = new System.Drawing.Size(229, 222);
            this.rTBLetters.TabIndex = 15;
            this.rTBLetters.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "*Abre el directorio en donde se encuentran las cartas comprimidas.";
            // 
            // btnWatchComp
            // 
            this.btnWatchComp.Location = new System.Drawing.Point(105, 271);
            this.btnWatchComp.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnWatchComp.Name = "btnWatchComp";
            this.btnWatchComp.Size = new System.Drawing.Size(154, 23);
            this.btnWatchComp.TabIndex = 14;
            this.btnWatchComp.Text = "Ver cartas comprimidas";
            this.btnWatchComp.UseVisualStyleBackColor = true;
            this.btnWatchComp.Click += new System.EventHandler(this.btnWatchComp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(359, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Compresión de cartas de recomendación";
            // 
            // gBCartas
            // 
            this.gBCartas.Controls.Add(this.label8);
            this.gBCartas.Controls.Add(this.btnComprimirCartas);
            this.gBCartas.Location = new System.Drawing.Point(22, 68);
            this.gBCartas.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gBCartas.Name = "gBCartas";
            this.gBCartas.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gBCartas.Size = new System.Drawing.Size(340, 74);
            this.gBCartas.TabIndex = 12;
            this.gBCartas.TabStop = false;
            this.gBCartas.Text = "Compresión de cartas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "*Esta acción permite comprimir todas las cartas de todos los reclutas";
            // 
            // btnComprimirCartas
            // 
            this.btnComprimirCartas.Location = new System.Drawing.Point(100, 24);
            this.btnComprimirCartas.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnComprimirCartas.Name = "btnComprimirCartas";
            this.btnComprimirCartas.Size = new System.Drawing.Size(115, 20);
            this.btnComprimirCartas.TabIndex = 3;
            this.btnComprimirCartas.Text = "Comprimir cartas";
            this.btnComprimirCartas.UseVisualStyleBackColor = true;
            this.btnComprimirCartas.Click += new System.EventHandler(this.btnComprimirCartas_Click);
            // 
            // gBBuscar
            // 
            this.gBBuscar.Controls.Add(this.label9);
            this.gBBuscar.Controls.Add(this.label7);
            this.gBBuscar.Controls.Add(this.btnDecompress);
            this.gBBuscar.Controls.Add(this.mTBBuscarDPI);
            this.gBBuscar.Location = new System.Drawing.Point(22, 162);
            this.gBBuscar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gBBuscar.Name = "gBBuscar";
            this.gBBuscar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gBBuscar.Size = new System.Drawing.Size(340, 85);
            this.gBBuscar.TabIndex = 11;
            this.gBBuscar.TabStop = false;
            this.gBBuscar.Text = "Descompresión de cartas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "*Introduce el DPI para descomprimir las cartas de recomendación\r\ndel recluta. Pod" +
    "rás observar sus cartas a la derecha.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DPI:";
            // 
            // btnDecompress
            // 
            this.btnDecompress.Location = new System.Drawing.Point(220, 53);
            this.btnDecompress.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(84, 20);
            this.btnDecompress.TabIndex = 6;
            this.btnDecompress.Text = "Descomprimir";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // mTBBuscarDPI
            // 
            this.mTBBuscarDPI.Location = new System.Drawing.Point(73, 55);
            this.mTBBuscarDPI.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.mTBBuscarDPI.Mask = "0000000000000";
            this.mTBBuscarDPI.Name = "mTBBuscarDPI";
            this.mTBBuscarDPI.Size = new System.Drawing.Size(134, 20);
            this.mTBBuscarDPI.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 380);
            this.Controls.Add(this.tCMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tCMenu.ResumeLayout(false);
            this.tPDataEntry.ResumeLayout(false);
            this.tPDataEntry.PerformLayout();
            this.tPImportFiles.ResumeLayout(false);
            this.tPImportFiles.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gBCartas.ResumeLayout(false);
            this.gBCartas.PerformLayout();
            this.gBBuscar.ResumeLayout(false);
            this.gBBuscar.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bImportConv;
        private System.Windows.Forms.Button bImportLetters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gBCartas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComprimirCartas;
        private System.Windows.Forms.GroupBox gBBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDecompress;
        private System.Windows.Forms.MaskedTextBox mTBBuscarDPI;
        private System.Windows.Forms.Button btnWatchComp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rTBLetters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

