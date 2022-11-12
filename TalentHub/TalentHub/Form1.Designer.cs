
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bimportFiles = new System.Windows.Forms.Button();
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
            this.tPImportFiles.Controls.Add(this.bimportFiles);
            this.tPImportFiles.Controls.Add(this.label4);
            this.tPImportFiles.Controls.Add(this.label3);
            this.tPImportFiles.Location = new System.Drawing.Point(4, 22);
            this.tPImportFiles.Margin = new System.Windows.Forms.Padding(2);
            this.tPImportFiles.Name = "tPImportFiles";
            this.tPImportFiles.Padding = new System.Windows.Forms.Padding(2);
            this.tPImportFiles.Size = new System.Drawing.Size(637, 336);
            this.tPImportFiles.TabIndex = 1;
            this.tPImportFiles.Text = "Import Files";
            this.tPImportFiles.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Recommendation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conversations";
            // 
            // bimportFiles
            // 
            this.bimportFiles.Location = new System.Drawing.Point(255, 96);
            this.bimportFiles.Name = "bimportFiles";
            this.bimportFiles.Size = new System.Drawing.Size(75, 23);
            this.bimportFiles.TabIndex = 2;
            this.bimportFiles.Text = "Import";
            this.bimportFiles.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button bimportFiles;
    }
}

