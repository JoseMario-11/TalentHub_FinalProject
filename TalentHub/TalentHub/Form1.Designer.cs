
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bImportConversation = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
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
            this.tPConversations = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rTBConversations = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bShowConversations = new System.Windows.Forms.Button();
            this.mTBConversationsDPI = new System.Windows.Forms.MaskedTextBox();
            this.tCMenu.SuspendLayout();
            this.tPDataEntry.SuspendLayout();
            this.tPImportFiles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBCartas.SuspendLayout();
            this.gBBuscar.SuspendLayout();
            this.tPConversations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMenu
            // 
            this.tCMenu.Controls.Add(this.tPDataEntry);
            this.tCMenu.Controls.Add(this.tPImportFiles);
            this.tCMenu.Controls.Add(this.tPConversations);
            this.tCMenu.Location = new System.Drawing.Point(8, 9);
            this.tCMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tCMenu.Name = "tCMenu";
            this.tCMenu.SelectedIndex = 0;
            this.tCMenu.Size = new System.Drawing.Size(645, 397);
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
            this.tPDataEntry.Size = new System.Drawing.Size(637, 371);
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
            this.tPImportFiles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tPImportFiles.Controls.Add(this.groupBox1);
            this.tPImportFiles.Controls.Add(this.label12);
            this.tPImportFiles.Controls.Add(this.rTBLetters);
            this.tPImportFiles.Controls.Add(this.label13);
            this.tPImportFiles.Controls.Add(this.label11);
            this.tPImportFiles.Controls.Add(this.btnWatchComp);
            this.tPImportFiles.Controls.Add(this.label10);
            this.tPImportFiles.Controls.Add(this.gBCartas);
            this.tPImportFiles.Controls.Add(this.gBBuscar);
            this.tPImportFiles.Location = new System.Drawing.Point(4, 22);
            this.tPImportFiles.Margin = new System.Windows.Forms.Padding(1);
            this.tPImportFiles.Name = "tPImportFiles";
            this.tPImportFiles.Padding = new System.Windows.Forms.Padding(1);
            this.tPImportFiles.Size = new System.Drawing.Size(637, 371);
            this.tPImportFiles.TabIndex = 2;
            this.tPImportFiles.Text = "Comprimir Cartas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.bImportConversation);
            this.groupBox1.Location = new System.Drawing.Point(16, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(594, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de conversaciones";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(15, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 30);
            this.label14.TabIndex = 4;
            this.label14.Text = "*Esta acción permite cargar al programa todas los archivos de texto de conversaci" +
    "ones entre reclutador y recluta";
            // 
            // bImportConversation
            // 
            this.bImportConversation.Location = new System.Drawing.Point(413, 18);
            this.bImportConversation.Margin = new System.Windows.Forms.Padding(1);
            this.bImportConversation.Name = "bImportConversation";
            this.bImportConversation.Size = new System.Drawing.Size(143, 23);
            this.bImportConversation.TabIndex = 3;
            this.bImportConversation.Text = "Cargar conversaciones";
            this.bImportConversation.UseVisualStyleBackColor = true;
            this.bImportConversation.Click += new System.EventHandler(this.bImportConversation_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(143, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(323, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "Importar conversaciones con reclutas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Cartas de recomendación del recluta";
            // 
            // rTBLetters
            // 
            this.rTBLetters.Location = new System.Drawing.Point(381, 62);
            this.rTBLetters.Margin = new System.Windows.Forms.Padding(1);
            this.rTBLetters.Name = "rTBLetters";
            this.rTBLetters.ReadOnly = true;
            this.rTBLetters.Size = new System.Drawing.Size(229, 200);
            this.rTBLetters.TabIndex = 15;
            this.rTBLetters.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "*Abre el directorio en donde se encuentran las cartas comprimidas.";
            // 
            // btnWatchComp
            // 
            this.btnWatchComp.Location = new System.Drawing.Point(99, 223);
            this.btnWatchComp.Margin = new System.Windows.Forms.Padding(1);
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
            this.label10.Location = new System.Drawing.Point(165, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Importar cartas de recomendación";
            // 
            // gBCartas
            // 
            this.gBCartas.Controls.Add(this.label8);
            this.gBCartas.Controls.Add(this.btnComprimirCartas);
            this.gBCartas.Location = new System.Drawing.Point(16, 57);
            this.gBCartas.Margin = new System.Windows.Forms.Padding(1);
            this.gBCartas.Name = "gBCartas";
            this.gBCartas.Padding = new System.Windows.Forms.Padding(1);
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
            this.btnComprimirCartas.Margin = new System.Windows.Forms.Padding(1);
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
            this.gBBuscar.Location = new System.Drawing.Point(16, 133);
            this.gBBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.gBBuscar.Name = "gBBuscar";
            this.gBBuscar.Padding = new System.Windows.Forms.Padding(1);
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
            this.btnDecompress.Margin = new System.Windows.Forms.Padding(1);
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
            this.mTBBuscarDPI.Margin = new System.Windows.Forms.Padding(1);
            this.mTBBuscarDPI.Mask = "0000000000000";
            this.mTBBuscarDPI.Name = "mTBBuscarDPI";
            this.mTBBuscarDPI.Size = new System.Drawing.Size(134, 20);
            this.mTBBuscarDPI.TabIndex = 0;
            // 
            // tPConversations
            // 
            this.tPConversations.Controls.Add(this.groupBox2);
            this.tPConversations.Controls.Add(this.label3);
            this.tPConversations.Controls.Add(this.rTBConversations);
            this.tPConversations.Location = new System.Drawing.Point(4, 22);
            this.tPConversations.Name = "tPConversations";
            this.tPConversations.Size = new System.Drawing.Size(637, 371);
            this.tPConversations.TabIndex = 3;
            this.tPConversations.Text = "Conversaciones";
            this.tPConversations.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Conversaciones del recluta";
            // 
            // rTBConversations
            // 
            this.rTBConversations.Location = new System.Drawing.Point(28, 149);
            this.rTBConversations.Margin = new System.Windows.Forms.Padding(1);
            this.rTBConversations.Name = "rTBConversations";
            this.rTBConversations.ReadOnly = true;
            this.rTBConversations.Size = new System.Drawing.Size(583, 200);
            this.rTBConversations.TabIndex = 17;
            this.rTBConversations.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bShowConversations);
            this.groupBox2.Controls.Add(this.mTBConversationsDPI);
            this.groupBox2.Location = new System.Drawing.Point(134, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(369, 85);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversaciones";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Introduce el DPI del recluta para visualizar las conversaciones de este. Podrás " +
    "observar las conversaciones en el recuadro de abajo.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DPI:";
            // 
            // bShowConversations
            // 
            this.bShowConversations.Location = new System.Drawing.Point(220, 53);
            this.bShowConversations.Margin = new System.Windows.Forms.Padding(1);
            this.bShowConversations.Name = "bShowConversations";
            this.bShowConversations.Size = new System.Drawing.Size(84, 20);
            this.bShowConversations.TabIndex = 6;
            this.bShowConversations.Text = "Mostrar cartas";
            this.bShowConversations.UseVisualStyleBackColor = true;
            this.bShowConversations.Click += new System.EventHandler(this.bShowConversations_Click);
            // 
            // mTBConversationsDPI
            // 
            this.mTBConversationsDPI.Location = new System.Drawing.Point(115, 54);
            this.mTBConversationsDPI.Margin = new System.Windows.Forms.Padding(1);
            this.mTBConversationsDPI.Mask = "0000000000000";
            this.mTBConversationsDPI.Name = "mTBConversationsDPI";
            this.mTBConversationsDPI.Size = new System.Drawing.Size(87, 20);
            this.mTBConversationsDPI.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 417);
            this.Controls.Add(this.tCMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Talent_Hub";
            this.tCMenu.ResumeLayout(false);
            this.tPDataEntry.ResumeLayout(false);
            this.tPDataEntry.PerformLayout();
            this.tPImportFiles.ResumeLayout(false);
            this.tPImportFiles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gBCartas.ResumeLayout(false);
            this.gBCartas.PerformLayout();
            this.gBBuscar.ResumeLayout(false);
            this.gBBuscar.PerformLayout();
            this.tPConversations.ResumeLayout(false);
            this.tPConversations.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tCMenu;
        private System.Windows.Forms.TabPage tPDataEntry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tPImportFiles;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bImportConversation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tPConversations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bShowConversations;
        private System.Windows.Forms.MaskedTextBox mTBConversationsDPI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTBConversations;
    }
}

