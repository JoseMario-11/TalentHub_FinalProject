
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
            this.label12 = new System.Windows.Forms.Label();
            this.rTBLetters = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bShowConversations = new System.Windows.Forms.Button();
            this.mTBConversationsDPI = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rTBConversations = new System.Windows.Forms.RichTextBox();
            this.tPCompleteProcess = new System.Windows.Forms.TabPage();
            this.bVerifyApplicant = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bVerifyCompany = new System.Windows.Forms.Button();
            this.tCMenu.SuspendLayout();
            this.tPDataEntry.SuspendLayout();
            this.tPImportFiles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBCartas.SuspendLayout();
            this.gBBuscar.SuspendLayout();
            this.tPConversations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tPCompleteProcess.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMenu
            // 
            this.tCMenu.Controls.Add(this.tPDataEntry);
            this.tCMenu.Controls.Add(this.tPImportFiles);
            this.tCMenu.Controls.Add(this.tPConversations);
            this.tCMenu.Controls.Add(this.tPCompleteProcess);
            this.tCMenu.Location = new System.Drawing.Point(11, 11);
            this.tCMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tCMenu.Name = "tCMenu";
            this.tCMenu.SelectedIndex = 0;
            this.tCMenu.Size = new System.Drawing.Size(860, 489);
            this.tCMenu.TabIndex = 0;
            // 
            // tPDataEntry
            // 
            this.tPDataEntry.Controls.Add(this.textBox1);
            this.tPDataEntry.Controls.Add(this.label2);
            this.tPDataEntry.Controls.Add(this.button1);
            this.tPDataEntry.Location = new System.Drawing.Point(4, 25);
            this.tPDataEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPDataEntry.Name = "tPDataEntry";
            this.tPDataEntry.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPDataEntry.Size = new System.Drawing.Size(852, 460);
            this.tPDataEntry.TabIndex = 0;
            this.tPDataEntry.Text = "Data entry";
            this.tPDataEntry.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(730, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta absoluta seleccionada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Archivo de entrada (CSV)";
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
            this.tPImportFiles.Location = new System.Drawing.Point(4, 25);
            this.tPImportFiles.Margin = new System.Windows.Forms.Padding(1);
            this.tPImportFiles.Name = "tPImportFiles";
            this.tPImportFiles.Padding = new System.Windows.Forms.Padding(1);
            this.tPImportFiles.Size = new System.Drawing.Size(852, 460);
            this.tPImportFiles.TabIndex = 2;
            this.tPImportFiles.Text = "Comprimir Cartas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.bImportConversation);
            this.groupBox1.Location = new System.Drawing.Point(21, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(792, 69);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de conversaciones";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(20, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(404, 37);
            this.label14.TabIndex = 4;
            this.label14.Text = "*Esta acción permite cargar al programa todas los archivos de texto de conversaci" +
    "ones entre reclutador y recluta";
            // 
            // bImportConversation
            // 
            this.bImportConversation.Location = new System.Drawing.Point(551, 22);
            this.bImportConversation.Margin = new System.Windows.Forms.Padding(1);
            this.bImportConversation.Name = "bImportConversation";
            this.bImportConversation.Size = new System.Drawing.Size(191, 28);
            this.bImportConversation.TabIndex = 3;
            this.bImportConversation.Text = "Cargar conversaciones";
            this.bImportConversation.UseVisualStyleBackColor = true;
            this.bImportConversation.Click += new System.EventHandler(this.bImportConversation_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Cartas de recomendación del recluta";
            // 
            // rTBLetters
            // 
            this.rTBLetters.Location = new System.Drawing.Point(508, 76);
            this.rTBLetters.Margin = new System.Windows.Forms.Padding(1);
            this.rTBLetters.Name = "rTBLetters";
            this.rTBLetters.ReadOnly = true;
            this.rTBLetters.Size = new System.Drawing.Size(304, 245);
            this.rTBLetters.TabIndex = 15;
            this.rTBLetters.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(191, 338);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(411, 29);
            this.label13.TabIndex = 17;
            this.label13.Text = "Importar conversaciones con reclutas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(432, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "*Abre el directorio en donde se encuentran las cartas comprimidas.";
            // 
            // btnWatchComp
            // 
            this.btnWatchComp.Location = new System.Drawing.Point(132, 274);
            this.btnWatchComp.Margin = new System.Windows.Forms.Padding(1);
            this.btnWatchComp.Name = "btnWatchComp";
            this.btnWatchComp.Size = new System.Drawing.Size(205, 28);
            this.btnWatchComp.TabIndex = 14;
            this.btnWatchComp.Text = "Ver cartas comprimidas";
            this.btnWatchComp.UseVisualStyleBackColor = true;
            this.btnWatchComp.Click += new System.EventHandler(this.btnWatchComp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(220, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(379, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Importar cartas de recomendación";
            // 
            // gBCartas
            // 
            this.gBCartas.Controls.Add(this.label8);
            this.gBCartas.Controls.Add(this.btnComprimirCartas);
            this.gBCartas.Location = new System.Drawing.Point(21, 70);
            this.gBCartas.Margin = new System.Windows.Forms.Padding(1);
            this.gBCartas.Name = "gBCartas";
            this.gBCartas.Padding = new System.Windows.Forms.Padding(1);
            this.gBCartas.Size = new System.Drawing.Size(453, 91);
            this.gBCartas.TabIndex = 12;
            this.gBCartas.TabStop = false;
            this.gBCartas.Text = "Compresión de cartas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(441, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "*Esta acción permite comprimir todas las cartas de todos los reclutas";
            // 
            // btnComprimirCartas
            // 
            this.btnComprimirCartas.Location = new System.Drawing.Point(133, 30);
            this.btnComprimirCartas.Margin = new System.Windows.Forms.Padding(1);
            this.btnComprimirCartas.Name = "btnComprimirCartas";
            this.btnComprimirCartas.Size = new System.Drawing.Size(153, 25);
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
            this.gBBuscar.Location = new System.Drawing.Point(21, 164);
            this.gBBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.gBBuscar.Name = "gBBuscar";
            this.gBBuscar.Padding = new System.Windows.Forms.Padding(1);
            this.gBBuscar.Size = new System.Drawing.Size(453, 105);
            this.gBBuscar.TabIndex = 11;
            this.gBBuscar.TabStop = false;
            this.gBBuscar.Text = "Descompresión de cartas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 34);
            this.label9.TabIndex = 8;
            this.label9.Text = "*Introduce el DPI para descomprimir las cartas de recomendación\r\ndel recluta. Pod" +
    "rás observar sus cartas a la derecha.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "DPI:";
            // 
            // btnDecompress
            // 
            this.btnDecompress.Location = new System.Drawing.Point(293, 65);
            this.btnDecompress.Margin = new System.Windows.Forms.Padding(1);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(112, 25);
            this.btnDecompress.TabIndex = 6;
            this.btnDecompress.Text = "Descomprimir";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // mTBBuscarDPI
            // 
            this.mTBBuscarDPI.Location = new System.Drawing.Point(97, 68);
            this.mTBBuscarDPI.Margin = new System.Windows.Forms.Padding(1);
            this.mTBBuscarDPI.Mask = "0000000000000";
            this.mTBBuscarDPI.Name = "mTBBuscarDPI";
            this.mTBBuscarDPI.Size = new System.Drawing.Size(177, 22);
            this.mTBBuscarDPI.TabIndex = 0;
            // 
            // tPConversations
            // 
            this.tPConversations.Controls.Add(this.groupBox2);
            this.tPConversations.Controls.Add(this.label3);
            this.tPConversations.Controls.Add(this.rTBConversations);
            this.tPConversations.Location = new System.Drawing.Point(4, 25);
            this.tPConversations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPConversations.Name = "tPConversations";
            this.tPConversations.Size = new System.Drawing.Size(852, 460);
            this.tPConversations.TabIndex = 3;
            this.tPConversations.Text = "Conversaciones";
            this.tPConversations.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bShowConversations);
            this.groupBox2.Controls.Add(this.mTBConversationsDPI);
            this.groupBox2.Location = new System.Drawing.Point(179, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(492, 105);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversaciones";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Introduce el DPI del recluta para visualizar las conversaciones de este. Podrás " +
    "observar las conversaciones en el recuadro de abajo.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "DPI:";
            // 
            // bShowConversations
            // 
            this.bShowConversations.Location = new System.Drawing.Point(293, 65);
            this.bShowConversations.Margin = new System.Windows.Forms.Padding(1);
            this.bShowConversations.Name = "bShowConversations";
            this.bShowConversations.Size = new System.Drawing.Size(112, 25);
            this.bShowConversations.TabIndex = 6;
            this.bShowConversations.Text = "Mostrar cartas";
            this.bShowConversations.UseVisualStyleBackColor = true;
            this.bShowConversations.Click += new System.EventHandler(this.bShowConversations_Click);
            // 
            // mTBConversationsDPI
            // 
            this.mTBConversationsDPI.Location = new System.Drawing.Point(153, 66);
            this.mTBConversationsDPI.Margin = new System.Windows.Forms.Padding(1);
            this.mTBConversationsDPI.Mask = "0000000000000";
            this.mTBConversationsDPI.Name = "mTBConversationsDPI";
            this.mTBConversationsDPI.Size = new System.Drawing.Size(115, 22);
            this.mTBConversationsDPI.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Conversaciones del recluta";
            // 
            // rTBConversations
            // 
            this.rTBConversations.Location = new System.Drawing.Point(37, 183);
            this.rTBConversations.Margin = new System.Windows.Forms.Padding(1);
            this.rTBConversations.Name = "rTBConversations";
            this.rTBConversations.ReadOnly = true;
            this.rTBConversations.Size = new System.Drawing.Size(776, 245);
            this.rTBConversations.TabIndex = 17;
            this.rTBConversations.Text = "";
            // 
            // tPCompleteProcess
            // 
            this.tPCompleteProcess.Controls.Add(this.groupBox3);
            this.tPCompleteProcess.Controls.Add(this.bVerifyApplicant);
            this.tPCompleteProcess.Location = new System.Drawing.Point(4, 25);
            this.tPCompleteProcess.Name = "tPCompleteProcess";
            this.tPCompleteProcess.Size = new System.Drawing.Size(852, 460);
            this.tPCompleteProcess.TabIndex = 5;
            this.tPCompleteProcess.Text = "Verificar candidato y completar proceso";
            this.tPCompleteProcess.UseVisualStyleBackColor = true;
            // 
            // bVerifyApplicant
            // 
            this.bVerifyApplicant.Location = new System.Drawing.Point(280, 30);
            this.bVerifyApplicant.Name = "bVerifyApplicant";
            this.bVerifyApplicant.Size = new System.Drawing.Size(267, 41);
            this.bVerifyApplicant.TabIndex = 0;
            this.bVerifyApplicant.Text = "Verificar información del recluta";
            this.bVerifyApplicant.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bVerifyCompany);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(79, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 328);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunicación com la empresa interesada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(635, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione el reclutador que esté llevando a cabo el proceso y la empresa interes" +
    "ada en el recluta ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(357, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Reclutador";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(354, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Empresa";
            // 
            // bVerifyCompany
            // 
            this.bVerifyCompany.Location = new System.Drawing.Point(201, 261);
            this.bVerifyCompany.Name = "bVerifyCompany";
            this.bVerifyCompany.Size = new System.Drawing.Size(259, 45);
            this.bVerifyCompany.TabIndex = 5;
            this.bVerifyCompany.Text = "Verificar empresa y finalizar proceso";
            this.bVerifyCompany.UseVisualStyleBackColor = true;
            this.bVerifyCompany.Click += new System.EventHandler(this.bVerifyCompany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 513);
            this.Controls.Add(this.tCMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tPCompleteProcess.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TabPage tPCompleteProcess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bVerifyCompany;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bVerifyApplicant;
    }
}

