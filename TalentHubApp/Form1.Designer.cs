
namespace TalentHubApp
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
            this.gBImportar = new System.Windows.Forms.GroupBox();
            this.tBSource = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPSearchName = new System.Windows.Forms.TabPage();
            this.rTBSearch = new System.Windows.Forms.RichTextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tPSearchDPI = new System.Windows.Forms.TabPage();
            this.rTBDPISearch = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mTBBuscarDPI = new System.Windows.Forms.MaskedTextBox();
            this.tPCodeDPI = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDPIDecod = new System.Windows.Forms.Label();
            this.mTBDPICod = new System.Windows.Forms.MaskedTextBox();
            this.btnCOD = new System.Windows.Forms.Button();
            this.tPCompressLetters = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.mTBDecompDPI = new System.Windows.Forms.MaskedTextBox();
            this.btnComprimirCartas = new System.Windows.Forms.Button();
            this.tPCipher = new System.Windows.Forms.TabPage();
            this.gBEncriptar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBKeyEncrypt = new System.Windows.Forms.TextBox();
            this.btnEncriptarConv = new System.Windows.Forms.Button();
            this.gBBuscar = new System.Windows.Forms.GroupBox();
            this.tBKeyDecrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.mTBDPIDecipher = new System.Windows.Forms.MaskedTextBox();
            this.tPIdentity = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.mTBC = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tBPublicKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBMessageDecrypted = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.mTBC2 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.mTBQ = new System.Windows.Forms.MaskedTextBox();
            this.mTBP = new System.Windows.Forms.MaskedTextBox();
            this.tBPrivateKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gBImportar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tPSearchName.SuspendLayout();
            this.tPSearchDPI.SuspendLayout();
            this.tPCodeDPI.SuspendLayout();
            this.tPCompressLetters.SuspendLayout();
            this.tPCipher.SuspendLayout();
            this.gBEncriptar.SuspendLayout();
            this.gBBuscar.SuspendLayout();
            this.tPIdentity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBImportar
            // 
            this.gBImportar.Controls.Add(this.tBSource);
            this.gBImportar.Controls.Add(this.btnImport);
            this.gBImportar.Location = new System.Drawing.Point(149, 142);
            this.gBImportar.Name = "gBImportar";
            this.gBImportar.Size = new System.Drawing.Size(793, 227);
            this.gBImportar.TabIndex = 6;
            this.gBImportar.TabStop = false;
            this.gBImportar.Text = "Importar";
            // 
            // tBSource
            // 
            this.tBSource.Location = new System.Drawing.Point(326, 96);
            this.tBSource.Name = "tBSource";
            this.tBSource.ReadOnly = true;
            this.tBSource.Size = new System.Drawing.Size(397, 35);
            this.tBSource.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(82, 91);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(196, 45);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Importar datos";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Talent Hub Guatemala";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPSearchName);
            this.tabControl1.Controls.Add(this.tPSearchDPI);
            this.tabControl1.Controls.Add(this.tPCodeDPI);
            this.tabControl1.Controls.Add(this.tPCompressLetters);
            this.tabControl1.Controls.Add(this.tPCipher);
            this.tabControl1.Controls.Add(this.tPIdentity);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(149, 422);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 718);
            this.tabControl1.TabIndex = 7;
            // 
            // tPSearchName
            // 
            this.tPSearchName.Controls.Add(this.rTBSearch);
            this.tPSearchName.Controls.Add(this.tBName);
            this.tPSearchName.Controls.Add(this.btnSearch);
            this.tPSearchName.Controls.Add(this.lblName);
            this.tPSearchName.Location = new System.Drawing.Point(10, 47);
            this.tPSearchName.Name = "tPSearchName";
            this.tPSearchName.Padding = new System.Windows.Forms.Padding(3);
            this.tPSearchName.Size = new System.Drawing.Size(781, 661);
            this.tPSearchName.TabIndex = 0;
            this.tPSearchName.Text = "Buscar nombre";
            this.tPSearchName.UseVisualStyleBackColor = true;
            // 
            // rTBSearch
            // 
            this.rTBSearch.Location = new System.Drawing.Point(68, 215);
            this.rTBSearch.Name = "rTBSearch";
            this.rTBSearch.ReadOnly = true;
            this.rTBSearch.Size = new System.Drawing.Size(616, 280);
            this.rTBSearch.TabIndex = 7;
            this.rTBSearch.Text = "";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(324, 44);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(232, 35);
            this.tBName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(279, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(181, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre:";
            // 
            // tPSearchDPI
            // 
            this.tPSearchDPI.Controls.Add(this.rTBDPISearch);
            this.tPSearchDPI.Controls.Add(this.label2);
            this.tPSearchDPI.Controls.Add(this.btnBuscar);
            this.tPSearchDPI.Controls.Add(this.mTBBuscarDPI);
            this.tPSearchDPI.Location = new System.Drawing.Point(10, 47);
            this.tPSearchDPI.Name = "tPSearchDPI";
            this.tPSearchDPI.Padding = new System.Windows.Forms.Padding(3);
            this.tPSearchDPI.Size = new System.Drawing.Size(781, 661);
            this.tPSearchDPI.TabIndex = 1;
            this.tPSearchDPI.Text = "Buscar DPI";
            this.tPSearchDPI.UseVisualStyleBackColor = true;
            // 
            // rTBDPISearch
            // 
            this.rTBDPISearch.Location = new System.Drawing.Point(67, 187);
            this.rTBDPISearch.Name = "rTBDPISearch";
            this.rTBDPISearch.ReadOnly = true;
            this.rTBDPISearch.Size = new System.Drawing.Size(641, 290);
            this.rTBDPISearch.TabIndex = 11;
            this.rTBDPISearch.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "DPI:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(513, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(196, 45);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mTBBuscarDPI
            // 
            this.mTBBuscarDPI.Location = new System.Drawing.Point(170, 101);
            this.mTBBuscarDPI.Mask = "0000000000000";
            this.mTBBuscarDPI.Name = "mTBBuscarDPI";
            this.mTBBuscarDPI.Size = new System.Drawing.Size(308, 35);
            this.mTBBuscarDPI.TabIndex = 8;
            this.mTBBuscarDPI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTBBuscarDPI_MaskInputRejected);
            // 
            // tPCodeDPI
            // 
            this.tPCodeDPI.Controls.Add(this.label3);
            this.tPCodeDPI.Controls.Add(this.lblDPIDecod);
            this.tPCodeDPI.Controls.Add(this.mTBDPICod);
            this.tPCodeDPI.Controls.Add(this.btnCOD);
            this.tPCodeDPI.Location = new System.Drawing.Point(10, 47);
            this.tPCodeDPI.Name = "tPCodeDPI";
            this.tPCodeDPI.Padding = new System.Windows.Forms.Padding(3);
            this.tPCodeDPI.Size = new System.Drawing.Size(781, 661);
            this.tPCodeDPI.TabIndex = 2;
            this.tPCodeDPI.Text = "Codificar DPI";
            this.tPCodeDPI.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "DPI:";
            // 
            // lblDPIDecod
            // 
            this.lblDPIDecod.AutoSize = true;
            this.lblDPIDecod.Location = new System.Drawing.Point(208, 276);
            this.lblDPIDecod.Name = "lblDPIDecod";
            this.lblDPIDecod.Size = new System.Drawing.Size(31, 29);
            this.lblDPIDecod.TabIndex = 15;
            this.lblDPIDecod.Text = "...";
            // 
            // mTBDPICod
            // 
            this.mTBDPICod.Location = new System.Drawing.Point(272, 123);
            this.mTBDPICod.Mask = "0000000000000";
            this.mTBDPICod.Name = "mTBDPICod";
            this.mTBDPICod.Size = new System.Drawing.Size(308, 35);
            this.mTBDPICod.TabIndex = 13;
            // 
            // btnCOD
            // 
            this.btnCOD.Location = new System.Drawing.Point(213, 205);
            this.btnCOD.Name = "btnCOD";
            this.btnCOD.Size = new System.Drawing.Size(317, 45);
            this.btnCOD.TabIndex = 12;
            this.btnCOD.Text = "Codificar/Decodificar";
            this.btnCOD.UseVisualStyleBackColor = true;
            this.btnCOD.Click += new System.EventHandler(this.btnCOD_Click);
            // 
            // tPCompressLetters
            // 
            this.tPCompressLetters.Controls.Add(this.label4);
            this.tPCompressLetters.Controls.Add(this.btnDecompress);
            this.tPCompressLetters.Controls.Add(this.mTBDecompDPI);
            this.tPCompressLetters.Controls.Add(this.btnComprimirCartas);
            this.tPCompressLetters.Location = new System.Drawing.Point(10, 47);
            this.tPCompressLetters.Name = "tPCompressLetters";
            this.tPCompressLetters.Padding = new System.Windows.Forms.Padding(3);
            this.tPCompressLetters.Size = new System.Drawing.Size(781, 661);
            this.tPCompressLetters.TabIndex = 3;
            this.tPCompressLetters.Text = "Comprimir cartas";
            this.tPCompressLetters.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "DPI:";
            // 
            // btnDecompress
            // 
            this.btnDecompress.Location = new System.Drawing.Point(271, 394);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(196, 45);
            this.btnDecompress.TabIndex = 9;
            this.btnDecompress.Text = "Descomprimir";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // mTBDecompDPI
            // 
            this.mTBDecompDPI.Location = new System.Drawing.Point(293, 311);
            this.mTBDecompDPI.Mask = "0000000000000";
            this.mTBDecompDPI.Name = "mTBDecompDPI";
            this.mTBDecompDPI.Size = new System.Drawing.Size(308, 35);
            this.mTBDecompDPI.TabIndex = 8;
            // 
            // btnComprimirCartas
            // 
            this.btnComprimirCartas.Location = new System.Drawing.Point(247, 146);
            this.btnComprimirCartas.Name = "btnComprimirCartas";
            this.btnComprimirCartas.Size = new System.Drawing.Size(269, 45);
            this.btnComprimirCartas.TabIndex = 4;
            this.btnComprimirCartas.Text = "Comprimir cartas";
            this.btnComprimirCartas.UseVisualStyleBackColor = true;
            this.btnComprimirCartas.Click += new System.EventHandler(this.btnComprimirCartas_Click);
            // 
            // tPCipher
            // 
            this.tPCipher.Controls.Add(this.gBEncriptar);
            this.tPCipher.Controls.Add(this.gBBuscar);
            this.tPCipher.Location = new System.Drawing.Point(10, 47);
            this.tPCipher.Name = "tPCipher";
            this.tPCipher.Padding = new System.Windows.Forms.Padding(3);
            this.tPCipher.Size = new System.Drawing.Size(781, 661);
            this.tPCipher.TabIndex = 4;
            this.tPCipher.Text = "Encriptar conversaciones";
            this.tPCipher.UseVisualStyleBackColor = true;
            // 
            // gBEncriptar
            // 
            this.gBEncriptar.Controls.Add(this.label5);
            this.gBEncriptar.Controls.Add(this.tBKeyEncrypt);
            this.gBEncriptar.Controls.Add(this.btnEncriptarConv);
            this.gBEncriptar.Location = new System.Drawing.Point(14, 83);
            this.gBEncriptar.Name = "gBEncriptar";
            this.gBEncriptar.Size = new System.Drawing.Size(742, 166);
            this.gBEncriptar.TabIndex = 17;
            this.gBEncriptar.TabStop = false;
            this.gBEncriptar.Text = "Encriptación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clave:";
            // 
            // tBKeyEncrypt
            // 
            this.tBKeyEncrypt.Location = new System.Drawing.Point(51, 93);
            this.tBKeyEncrypt.Name = "tBKeyEncrypt";
            this.tBKeyEncrypt.Size = new System.Drawing.Size(323, 35);
            this.tBKeyEncrypt.TabIndex = 2;
            // 
            // btnEncriptarConv
            // 
            this.btnEncriptarConv.Location = new System.Drawing.Point(408, 66);
            this.btnEncriptarConv.Name = "btnEncriptarConv";
            this.btnEncriptarConv.Size = new System.Drawing.Size(315, 45);
            this.btnEncriptarConv.TabIndex = 3;
            this.btnEncriptarConv.Text = "Encriptar conversaciones";
            this.btnEncriptarConv.UseVisualStyleBackColor = true;
            this.btnEncriptarConv.Click += new System.EventHandler(this.btnEncriptarConv_Click);
            // 
            // gBBuscar
            // 
            this.gBBuscar.Controls.Add(this.tBKeyDecrypt);
            this.gBBuscar.Controls.Add(this.label6);
            this.gBBuscar.Controls.Add(this.label7);
            this.gBBuscar.Controls.Add(this.btnDecrypt);
            this.gBBuscar.Controls.Add(this.mTBDPIDecipher);
            this.gBBuscar.Location = new System.Drawing.Point(14, 278);
            this.gBBuscar.Name = "gBBuscar";
            this.gBBuscar.Size = new System.Drawing.Size(742, 190);
            this.gBBuscar.TabIndex = 16;
            this.gBBuscar.TabStop = false;
            this.gBBuscar.Text = "Buscar";
            // 
            // tBKeyDecrypt
            // 
            this.tBKeyDecrypt.Location = new System.Drawing.Point(175, 122);
            this.tBKeyDecrypt.Name = "tBKeyDecrypt";
            this.tBKeyDecrypt.Size = new System.Drawing.Size(308, 35);
            this.tBKeyDecrypt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clave:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "DPI:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(527, 84);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(196, 45);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Desencriptar";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // mTBDPIDecipher
            // 
            this.mTBDPIDecipher.Location = new System.Drawing.Point(175, 68);
            this.mTBDPIDecipher.Mask = "0000000000000";
            this.mTBDPIDecipher.Name = "mTBDPIDecipher";
            this.mTBDPIDecipher.Size = new System.Drawing.Size(308, 35);
            this.mTBDPIDecipher.TabIndex = 0;
            // 
            // tPIdentity
            // 
            this.tPIdentity.Controls.Add(this.groupBox2);
            this.tPIdentity.Controls.Add(this.label11);
            this.tPIdentity.Controls.Add(this.tBPublicKey);
            this.tPIdentity.Controls.Add(this.groupBox1);
            this.tPIdentity.Location = new System.Drawing.Point(10, 47);
            this.tPIdentity.Name = "tPIdentity";
            this.tPIdentity.Padding = new System.Windows.Forms.Padding(3);
            this.tPIdentity.Size = new System.Drawing.Size(781, 661);
            this.tPIdentity.TabIndex = 5;
            this.tPIdentity.Text = "Identidad";
            this.tPIdentity.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBMessage);
            this.groupBox2.Controls.Add(this.mTBC);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnEncrypt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(62, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 230);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company";
            // 
            // tBMessage
            // 
            this.tBMessage.Location = new System.Drawing.Point(254, 37);
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(271, 35);
            this.tBMessage.TabIndex = 18;
            // 
            // mTBC
            // 
            this.mTBC.Location = new System.Drawing.Point(207, 168);
            this.mTBC.Name = "mTBC";
            this.mTBC.Size = new System.Drawing.Size(283, 35);
            this.mTBC.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "c:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(197, 93);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(226, 54);
            this.btnEncrypt.TabIndex = 15;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mensaje:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Public key:";
            // 
            // tBPublicKey
            // 
            this.tBPublicKey.Location = new System.Drawing.Point(326, 372);
            this.tBPublicKey.Name = "tBPublicKey";
            this.tBPublicKey.Size = new System.Drawing.Size(271, 35);
            this.tBPublicKey.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBMessageDecrypted);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.mTBC2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnGenerateKeys);
            this.groupBox1.Controls.Add(this.mTBQ);
            this.groupBox1.Controls.Add(this.mTBP);
            this.groupBox1.Controls.Add(this.tBPrivateKey);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(58, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recluiter";
            // 
            // tBMessageDecrypted
            // 
            this.tBMessageDecrypted.Location = new System.Drawing.Point(383, 228);
            this.tBMessageDecrypted.Name = "tBMessageDecrypted";
            this.tBMessageDecrypted.Size = new System.Drawing.Size(212, 35);
            this.tBMessageDecrypted.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Decrypt message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 29);
            this.label15.TabIndex = 9;
            this.label15.Text = "M:";
            // 
            // mTBC2
            // 
            this.mTBC2.Location = new System.Drawing.Point(66, 234);
            this.mTBC2.Name = "mTBC2";
            this.mTBC2.Size = new System.Drawing.Size(210, 35);
            this.mTBC2.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 29);
            this.label14.TabIndex = 7;
            this.label14.Text = "c:";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(479, 49);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(130, 82);
            this.btnGenerateKeys.TabIndex = 6;
            this.btnGenerateKeys.Text = "Generate keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // mTBQ
            // 
            this.mTBQ.Location = new System.Drawing.Point(114, 96);
            this.mTBQ.Name = "mTBQ";
            this.mTBQ.Size = new System.Drawing.Size(283, 35);
            this.mTBQ.TabIndex = 5;
            // 
            // mTBP
            // 
            this.mTBP.Location = new System.Drawing.Point(114, 42);
            this.mTBP.Name = "mTBP";
            this.mTBP.Size = new System.Drawing.Size(283, 35);
            this.mTBP.TabIndex = 4;
            // 
            // tBPrivateKey
            // 
            this.tBPrivateKey.Location = new System.Drawing.Point(258, 167);
            this.tBPrivateKey.Name = "tBPrivateKey";
            this.tBPrivateKey.Size = new System.Drawing.Size(271, 35);
            this.tBPrivateKey.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "q:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "p:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Private key:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 1193);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gBImportar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBImportar.ResumeLayout(false);
            this.gBImportar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tPSearchName.ResumeLayout(false);
            this.tPSearchName.PerformLayout();
            this.tPSearchDPI.ResumeLayout(false);
            this.tPSearchDPI.PerformLayout();
            this.tPCodeDPI.ResumeLayout(false);
            this.tPCodeDPI.PerformLayout();
            this.tPCompressLetters.ResumeLayout(false);
            this.tPCompressLetters.PerformLayout();
            this.tPCipher.ResumeLayout(false);
            this.gBEncriptar.ResumeLayout(false);
            this.gBEncriptar.PerformLayout();
            this.gBBuscar.ResumeLayout(false);
            this.gBBuscar.PerformLayout();
            this.tPIdentity.ResumeLayout(false);
            this.tPIdentity.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBImportar;
        private System.Windows.Forms.TextBox tBSource;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPSearchName;
        private System.Windows.Forms.TabPage tPSearchDPI;
        private System.Windows.Forms.TabPage tPCodeDPI;
        private System.Windows.Forms.TabPage tPCompressLetters;
        private System.Windows.Forms.TabPage tPCipher;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rTBSearch;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tPIdentity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mTBBuscarDPI;
        private System.Windows.Forms.RichTextBox rTBDPISearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDPIDecod;
        private System.Windows.Forms.MaskedTextBox mTBDPICod;
        private System.Windows.Forms.Button btnCOD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecompress;
        private System.Windows.Forms.MaskedTextBox mTBDecompDPI;
        private System.Windows.Forms.Button btnComprimirCartas;
        private System.Windows.Forms.GroupBox gBEncriptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBKeyEncrypt;
        private System.Windows.Forms.Button btnEncriptarConv;
        private System.Windows.Forms.GroupBox gBBuscar;
        private System.Windows.Forms.TextBox tBKeyDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.MaskedTextBox mTBDPIDecipher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBPublicKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.MaskedTextBox mTBQ;
        private System.Windows.Forms.MaskedTextBox mTBP;
        private System.Windows.Forms.TextBox tBPrivateKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mTBC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mTBC2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBMessage;
        private System.Windows.Forms.TextBox tBMessageDecrypted;
    }
}

