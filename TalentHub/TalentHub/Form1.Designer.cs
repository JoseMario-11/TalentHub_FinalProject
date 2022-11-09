
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tPUploadFiles = new System.Windows.Forms.TabPage();
            this.bFilesSelect = new System.Windows.Forms.Button();
            this.tCMenu.SuspendLayout();
            this.tPUploadFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMenu
            // 
            this.tCMenu.Controls.Add(this.tabPage1);
            this.tCMenu.Controls.Add(this.tabPage2);
            this.tCMenu.Controls.Add(this.tPUploadFiles);
            this.tCMenu.Location = new System.Drawing.Point(32, 53);
            this.tCMenu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tCMenu.Name = "tCMenu";
            this.tCMenu.SelectedIndex = 0;
            this.tCMenu.Size = new System.Drawing.Size(395, 262);
            this.tCMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(387, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Size = new System.Drawing.Size(387, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tPUploadFiles
            // 
            this.tPUploadFiles.Controls.Add(this.bFilesSelect);
            this.tPUploadFiles.Location = new System.Drawing.Point(4, 22);
            this.tPUploadFiles.Name = "tPUploadFiles";
            this.tPUploadFiles.Size = new System.Drawing.Size(387, 236);
            this.tPUploadFiles.TabIndex = 2;
            this.tPUploadFiles.Text = "Cargar archivos";
            this.tPUploadFiles.UseVisualStyleBackColor = true;
            // 
            // bFilesSelect
            // 
            this.bFilesSelect.Location = new System.Drawing.Point(132, 95);
            this.bFilesSelect.Name = "bFilesSelect";
            this.bFilesSelect.Size = new System.Drawing.Size(127, 28);
            this.bFilesSelect.TabIndex = 0;
            this.bFilesSelect.Text = "Seleccionar carpeta";
            this.bFilesSelect.UseVisualStyleBackColor = true;
            this.bFilesSelect.Click += new System.EventHandler(this.bFilesSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 343);
            this.Controls.Add(this.tCMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tCMenu.ResumeLayout(false);
            this.tPUploadFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tCMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bFilesSelect;
        private System.Windows.Forms.TabPage tPUploadFiles;
    }
}

